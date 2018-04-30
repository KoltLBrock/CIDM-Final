using Microsoft.EntityFrameworkCore;

namespace BuffteksWebsite.Models
{
    public class BuffteksWebsiteContext : DbContext
    {
        public BuffteksWebsiteContext (DbContextOptions<BuffteksWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<BuffteksWebsite.Models.Member> Members { get; set; }
        public DbSet<BuffteksWebsite.Models.Client> Clients { get; set; }
        public DbSet<BuffteksWebsite.Models.Project> Projects { get; set; }
    }
}