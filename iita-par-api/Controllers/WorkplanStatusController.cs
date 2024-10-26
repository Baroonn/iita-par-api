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
    [Route("api/workplans/status")]
    [ApiController]
    [Authorize]
    public class WorkplanStatusController(PARContext _context, IMapper _mapper) : ControllerBase
    {
        [HttpGet("logs")]
        public async Task<IActionResult> GetLogs([FromQuery] int year)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }
            var actionStatus = await _context.Workplanactionstatuses.Include(x => x.Workplanstatuslogs).FirstOrDefaultAsync(x => x.AppraiseeId == userId && x.Year == year);
            return Ok(_mapper.Map<List<WorkplanStatusLogReadDTO>>(actionStatus?.Workplanstatuslogs ?? []));
        }

        [HttpPost("logs")]
        public async Task<IActionResult> CreateLog([FromBody] WorkplanStatusLogCreateDTO statusLogDto)
        {
            List<Workplanstatuslog> statusLogs = new();
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var actionStatus = await _context.Workplanactionstatuses.Include(x=>x.Workplanstatuslogs).FirstOrDefaultAsync(x => x.AppraiseeId == userId && x.Year == statusLogDto.Year);

            if (actionStatus == null)
            {
                actionStatus = new Workplanactionstatus()
                {
                    ApprovalStatus = "DRAFT",
                    SubmissionStatus = "DRAFT",
                    Year = statusLogDto.Year,
                    AppraiseeId = userId,
                    Version = 1,
                    CreatedDate = DateTime.Now,
                    LastUpdated = DateTime.Now
                };

                _context.Workplanactionstatuses.Add(actionStatus);
                await _context.SaveChangesAsync();
            }
            var statusLog = _mapper.Map<Workplanstatuslog>(statusLogDto);
            statusLog.UserId = userId;
            statusLog.WorkplanActionStatusId = actionStatus.Id;
            statusLog.CreatedDate = DateTime.Now;
            statusLog.LastUpdated = DateTime.Now;
            actionStatus.Workplanstatuslogs.Add(statusLog);
            await _context.SaveChangesAsync();

            return Created();
        }
    }
}
