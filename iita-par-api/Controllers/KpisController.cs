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
    [Route("api/workplans/{year:int:length(4)}/objectives/{objectiveId:long}/kpis")]
    [ApiController]
    [Authorize]
    public class KpisController : ControllerBase
    {
        private readonly PARContext _context;
        private readonly IMapper _mapper;
        public KpisController(PARContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetKpis(int year, long objectiveId)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var objective = await _context.Irsworkplans.FirstOrDefaultAsync(x => x.UserId == userId && x.Year == year && x.Id == objectiveId);
            if (objective == null)
            {
                return NotFound();
            }

            var kpis = await _context.Irskpis.Where(x => x.WorkplanId == objectiveId).ToListAsync();

            return Ok(_mapper.Map<List<KpiReadDTO>>(kpis));
        }

        [HttpGet("{kpiId:long}")]
        public async Task<IActionResult> GetKpi(int year, long objectiveId, long kpiId)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var objective = await _context.Irsworkplans.FirstOrDefaultAsync(x => x.UserId == userId && x.Year == year && x.Id == objectiveId);
            if (objective == null)
            {
                return NotFound();
            }

            var kpi = await _context.Irskpis.FirstOrDefaultAsync(x => x.WorkplanId == objectiveId && x.Id == kpiId);
            if (kpi == null) 
            {
                return NotFound();
            }

            return Ok(_mapper.Map<KpiReadDTO>(kpi));
        }

        [HttpPost]
        public async Task<IActionResult> CreateKpi(int year, long objectiveId, KpiCreateDTO kpi)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var objective = await _context.Irsworkplans.FirstOrDefaultAsync(x => x.UserId == userId && x.Year == year && x.Id == objectiveId);
            if (objective == null)
            {
                return NotFound();
            }

            var newKpi = _mapper.Map<Irskpi>(kpi);
            newKpi.CreatedDate = DateTime.Now;
            newKpi.LastUpdated = newKpi.CreatedDate;
            newKpi.WorkplanId = objectiveId;
            newKpi.Version = 1;

            _context.Irskpis.Add(newKpi);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKpi", new { id = newKpi.Id }, _mapper.Map<KpiReadDTO>(newKpi));
        }

        [HttpPut("{kpiId:long}")]
        public async Task<IActionResult> PutKpi(int year, long objectiveId, long kpiId, KpiUpdateDTO kpiUpdate)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var objective = await _context.Irsworkplans.FirstOrDefaultAsync(x => x.UserId == userId && x.Year == year && x.Id == objectiveId);
            if (objective == null)
            {
                return NotFound();
            }

            var kpi = await _context.Irskpis.FirstOrDefaultAsync(x => x.WorkplanId == objectiveId && x.Id == kpiId);
            if (kpi == null)
            {
                return NotFound();
            }

            _mapper.Map(kpiUpdate, kpi);
            kpi.LastUpdated = DateTime.Now;
            kpi.Version++;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{kpiId:long}")]
        public async Task<IActionResult> DeleteKpi(int year, long objectiveId, long kpiId)
        {
            if (!long.TryParse(User.FindFirst(CustomClaimType.UserIdIdentifier)?.Value, out long userId))
            {
                return BadRequest();
            }

            var objective = await _context.Irsworkplans.FirstOrDefaultAsync(x => x.UserId == userId && x.Year == year && x.Id == objectiveId);
            if (objective == null)
            {
                return NotFound();
            }

            var kpi = await _context.Irskpis.FirstOrDefaultAsync(x => x.WorkplanId == objectiveId && x.Id == kpiId);
            if (kpi == null)
            {
                return NotFound();
            }

            _context.Irskpis.Remove(kpi);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
