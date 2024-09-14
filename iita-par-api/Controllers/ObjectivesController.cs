using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAR.Infrastructure.Data;
using PAR.Infrastructure.Models;
using PAR.Shared.Constants;
using PAR.Shared.DTOs;
using System.Security.Claims;

namespace iita_par_api.Controllers
{
    [Route("api/workplans/objectives")]
    [ApiController]
    [Authorize]
    public class ObjectivesController : ControllerBase
    {
        private readonly PARContext _context;
        private readonly IMapper _mapper;
        public ObjectivesController(PARContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetObjectives([FromQuery] int year)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var objectives = await _context.Irsworkplans.Include(x => x.User).Where(x => x.UserId == userId && x.Year == year).ToListAsync();
            var toBeReturned = _mapper.Map<List<ObjectiveReadDTO>>(objectives);
            return Ok(toBeReturned);
        }

        [HttpGet("{objectiveId:long}")]
        public async Task<IActionResult> GetObjective(long objectiveId)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var objective = await _context.Irsworkplans.Include(x => x.User).FirstOrDefaultAsync(x => x.UserId == userId && x.Id == objectiveId);
            if (objective == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ObjectiveReadDTO>(objective));
        }

        [HttpPost]
        public async Task<IActionResult> CreateObjective(ObjectiveCreateDTO objective)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var newObjective = _mapper.Map<Irsworkplan>(objective);
            newObjective.DateCreated = DateTime.Now;
            newObjective.DateUpdated = newObjective.DateCreated;
            newObjective.Version = 1;
            newObjective.UserId = userId;

            _context.Irsworkplans.Add(newObjective);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObjective", new { objectiveId = newObjective.Id }, _mapper.Map<ObjectiveReadDTO>(newObjective));
        }

        [HttpPut("{objectiveId:long}")]
        public async Task<IActionResult> PutObjective(long objectiveId, ObjectiveUpdateDTO newObjective)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var oldObjective = await _context.Irsworkplans.FirstOrDefaultAsync(x => x.UserId == userId && x.Id == objectiveId);

            if(oldObjective == null)
            {
                return NotFound();
            }

            _mapper.Map(newObjective, oldObjective);
            oldObjective.DateUpdated = DateTime.Now;
            oldObjective.Version++;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{objectiveId:long}")]
        public async Task<IActionResult> DeleteObjective(long objectiveId)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var oldObjective = await _context.Irsworkplans.FirstOrDefaultAsync(x => x.UserId == userId && x.Id == objectiveId);

            if (oldObjective == null)
            {
                return NotFound();
            }

            _context.Irsworkplans.Remove(oldObjective);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
