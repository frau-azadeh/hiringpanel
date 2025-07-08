using Microsoft.EntityFrameworkCore;

public class HiringPanelDbContext : DbContext
{
    public HiringPanelDbContext(DbContextOptions<HiringPanelDbContext> options)
        : base(options)
    {
    }

    public DbSet<Applicant> Applicants { get; set; }
}
