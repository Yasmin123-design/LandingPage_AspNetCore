using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LandingPageTask.Data;
using LandingPageTask.Models;

namespace LandingPageTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultationController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ConsultationController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var requests = await _context.ConsultationRequests.OrderByDescending(r => r.CreatedAt).ToListAsync();
            return Ok(requests);
        }

        [HttpPost]
        public async Task<IActionResult> Submit(ConsultationRequest request)
        {
            _context.ConsultationRequests.Add(request);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Request submitted successfully" });
        }
    }
}
