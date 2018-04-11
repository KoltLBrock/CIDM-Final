using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BuffteksWebsite.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BuffteksWebsiteContext(
                serviceProvider.GetRequiredService<DbContextOptions<BuffteksWebsiteContext>>()))
            {
                // Look for any movies.
                if (context.Member.Any())
                {
                    return;   // DB has been seeded
                }

                context.Member.AddRange(
                     new Member
                     {
                         MemberID = 1,
                         FirstName = "John",
                         LastName = "Smith",
                         Standing = "Senior",
                         Major = "CIS",
                         Birthday = "January 1, 1200",
                         Email = "test@tets.com",
                         Phone = "555-555-5555"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}