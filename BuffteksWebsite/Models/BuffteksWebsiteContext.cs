using Microsoft.EntityFrameworkCore;

namespace BuffteksWebsite.Models
{
    public class BuffteksWebsiteContext : DbContext
    {
        public BuffteksWebsiteContext (DbContextOptions<BuffteksWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<BuffteksWebsite.Models.Member> Member { get; set; }
        public DbSet<BuffteksWebsite.Models.Member> Client { get; set; }
        public DbSet<BuffteksWebsite.Models.Member> Project { get; set; }
    }
}