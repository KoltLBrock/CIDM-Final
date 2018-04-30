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
                if (context.Members.Any()){
                    return;   // DB has been seeded
                }
                context.Members.AddRange(
                     new Member
                     {
                         MemberUserName = "JohnSmith",
                         FirstName = "John",
                         LastName = "Smith",
                         Standing = "Senior",
                         Major = "CIS",
                         Birthday = "January 1, 1200",
                         Email = "test@tets.com",
                         Phone = "555-555-5555"
                     },
                    new Member
                     {
                         MemberUserName = "Jeff01",
                         FirstName = "Jeff",
                         LastName = "Salad",
                         Standing = "Junior",
                         Major = "CIS",
                         Birthday = "January 1, 1220",
                         Email = "test1@tets.com",
                         Phone = "555-555-5556"
                     }
                );
                if (context.Clients.Any()){
                return;
                }
                context.Clients.AddRange(
                     new Client
                     {
                         ClientUserName = "BobBobert",
                         FirstName = "Bob",
                         LastName = "Bobert",
                         Email = "hi@test.com",
                         Phone = "666-666-6666"
                     },
                     new Client
                     {
                         ClientUserName = "Georgie",
                         FirstName = "George",
                         LastName = "David",
                         Email = "hi@test.com",
                         Phone = "666-666-6666"
                     }
                );
                if (context.Projects.Any()){
                    return;
                }
                context.Projects.AddRange(
                    new Project
                    {
                        ProjectName = "Example Project",
                        Details = "Example Project Description"
                    },
                    new Project
                    {
                        ProjectName = "Example Project 2",
                        Details = "Example Project Description 2"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}