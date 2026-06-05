using Microsoft.EntityFrameworkCore;
using LandingPageTask.Models;

namespace LandingPageTask.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ConsultationRequest> ConsultationRequests { get; set; }
    }
}
