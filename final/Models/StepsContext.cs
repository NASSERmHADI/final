using Microsoft.EntityFrameworkCore;

namespace final.Models
{
    public class StepsContext : DbContext
    {
        public StepsContext(DbContextOptions<StepsContext> options) : base(options)
        {
        }
        public DbSet<Step> Steps { get; set; }
    }
}
