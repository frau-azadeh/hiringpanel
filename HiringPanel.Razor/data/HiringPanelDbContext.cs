using Microsoft.EntityFrameworkCore;
using HiringPanel.Razor.Models;

namespace HiringPanel.Razor.Data
{
    public class HiringPanelDbContext : DbContext
    {
        public HiringPanelDbContext(DbContextOptions<HiringPanelDbContext> options)
            : base(options)
        {
        }

        public DbSet<Applicant> Applicants { get; set; }
    }
}
