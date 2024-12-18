﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAR.Infrastructure.Data;
using PAR.Infrastructure.Models;
using PAR.Shared.Constants;
using PAR.Shared.DTOs;
using PAR.Shared.Enums;
using System.Linq;
using System.Security.Claims;

namespace iita_par_api.Controllers
{
    [Route("api/appraisals")]
    [ApiController]
    [Authorize]
    public class AppraisalsController(PARContext _context, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAppraisals([FromQuery] int year)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var appraisals = await _context.Appraisals.Include(x => x.Country).Where(x => (x.AppraiserId == userId || x.AppraiseeId == userId) && x.YearOfAppraisal == year).ToListAsync();
            
            if (!appraisals.Any(x => x.AppraiserId == userId))
            {
                var supervisees = await _context.Usersupervisors.Include(x => x.User).Where(x => x.SupervisorId == userId).ToListAsync();
                foreach(var supervisee in supervisees)
                {
                    var appraisal = new Appraisal()
                    {
                        AppraiseeName = supervisee.User.DisplayName,
                        AppraiserId = userId,
                        AppraiseeId = supervisee.User.Id,
                        YearOfAppraisal = year,
                        State = "PENDING",
                        Type = "IRS"
                    };
                    List<Appraisalscore> appraisalScores = new List<Appraisalscore>();

                    foreach (AppraisalScoreKey key in Enum.GetValues(typeof(AppraisalScoreKey)))
                    {
                        appraisalScores.Add(new Appraisalscore
                        {
                            ScoreKey = key.ToString(), // Convert enum value to string
                            Score = 0 // Default score (set to your desired initial value)
                        });
                    }
                    appraisal.Appraisalscores = appraisalScores;
                    _context.Appraisals.Add(appraisal);
                }
                await _context.SaveChangesAsync();

                appraisals = await _context.Appraisals.Where(x => (x.AppraiserId == userId || x.AppraiseeId == userId) && x.YearOfAppraisal == year).ToListAsync();

            }

            return Ok(_mapper.Map<List<AppraisalReadDTO>>(appraisals));
        }

        [HttpGet("{id:long}")]
        public async Task<IActionResult> GetAppraisal(long id)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var appraisal = await _context.Appraisals.Include(x => x.Appraisalscores).Include(x => x.Country).FirstOrDefaultAsync(x => x.Id == id && (x.AppraiseeId == userId || x.AppraiserId == userId));
            if (appraisal == null)
            {
                return NotFound();
            }

            var appraisalReturned = _mapper.Map<AppraisalReadDTO>(appraisal);
            var workplan = await _context.Irsworkplans.FirstOrDefaultAsync(x => x.Year == appraisal.YearOfAppraisal && appraisal.AppraiseeId == x.UserId);
            appraisalReturned.WorkplanUploaded = workplan != null;
            appraisalReturned.WorkplanApproved = workplan != null && workplan.Status == (int)WorkplanStatus.Approved;
            appraisalReturned.WorkplanSubmitted = appraisalReturned.WorkplanApproved || workplan?.Status == (int)WorkplanStatus.Submitted;

            appraisalReturned.FinalScore =
                (appraisalReturned.Score[AppraisalScoreKey.WorkplanAchievement] * 20)
                + (appraisalReturned.Score[AppraisalScoreKey.InterRelations] * 10)
                + (appraisalReturned.Score[AppraisalScoreKey.Initiative] * 10)
                + (appraisalReturned.Score[AppraisalScoreKey.Communication] * 10)
                + (appraisalReturned.Score[AppraisalScoreKey.Compliance] * 10);
            return Ok(appraisalReturned);
        }

        [HttpPut("{id:long}")]
        public async Task<IActionResult> EditAppraisal(long id, [FromBody]AppraisalEditDTO appraisalEdit)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var appraisal = await _context.Appraisals.Include(x => x.Appraisalscores).FirstOrDefaultAsync(x => x.Id == id && (x.AppraiseeId == userId || x.AppraiserId == userId));
            if (appraisal == null)
            {
                return NotFound();
            }

            //make sure appraisalscores is provided
            appraisal.Appraisalscores = [];

            _mapper.Map(appraisalEdit, appraisal);
            appraisal.LastUpdated = DateTime.Now;
            appraisal.LastUpdatedBy = User.FindFirst(ClaimTypes.Name)?.Value ?? "supervisor";
            await _context.SaveChangesAsync();
            return Ok(_mapper.Map<AppraisalReadDTO>(appraisal));
        }
    }
}
