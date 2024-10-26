using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAR.Infrastructure.Data;
using PAR.Infrastructure.Models;
using PAR.Shared.Constants;
using PAR.Shared.DTOs;

namespace iita_par_api.Controllers
{
    [Route("api/activities")]
    [ApiController]
    [Authorize]
    public class ActivitiesController(PARContext _context, IMapper _mapper) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateActivity(ActivityCreateDTO activity)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var newActivity = _mapper.Map<Irsactivity>(activity);
            newActivity.CreatedDate = DateTime.Now;
            newActivity.LastUpdated = newActivity.CreatedDate;
            newActivity.Version = 1;
            newActivity.UserId = userId;

            _context.Irsactivities.Add(newActivity);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActivity", new { activityId = newActivity.Id }, _mapper.Map<ActivityReadDTO>(newActivity));
        }

        [HttpGet("{activityId:long}")]
        public async Task<IActionResult> GetActivity(long activityId)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var activity = await _context.Irsactivities.Include(x => x.User).FirstOrDefaultAsync(x => x.UserId == userId && x.Id == activityId);
            if (activity == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ActivityReadDTO>(activity));
        }

    }
}
