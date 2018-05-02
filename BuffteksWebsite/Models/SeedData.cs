using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BuffteksWebsite.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new BuffteksWebsiteContext(serviceProvider.GetRequiredService<DbContextOptions<BuffteksWebsiteContext>>()))
            {
                //replaced old SeedData with this one from ahuimanu github for elegance and simplicity

                // CLIENTS
                if (context.Clients.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                var clients = new List<Client>
                {
                    new Client { FirstName="Jimmie", LastName="Ramos", CompanyName="ACME", Email="jramos@acme.com", Phone="555-555-5555" },
                    new Client { FirstName="Kristy", LastName="Miles", CompanyName="World Wide Industries", Email="kmiles@wwi.com", Phone="555-555-5555" },
                    new Client { FirstName="Shelley", LastName="Walker", CompanyName="Big Money Inc", Email="swalker@bigmoneyinc.com", Phone="555-555-5555" }
                };
                context.AddRange(clients);
                context.SaveChanges();


                // CLIENTS
                if (context.Members.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                var members = new List<Member>
                {
                    new Member { FirstName="Mamie", LastName="Santiago", Major="CIS", Email="msantiago@buffs.wtamu.edu", Phone="555-555-5555", Standing = "Junior" },
                    new Member { FirstName="Pete", LastName="Perez", Major="CIS", Email="pperez@buffs.wtamu.edu", Phone="555-555-5555", Standing = "Junior" },
                    new Member { FirstName="Flora", LastName="Williamson", Major="CIS", Email="fwiliamson@buffs.wtamu.edu", Phone="555-555-5555", Standing = "Junior" },
                    new Member { FirstName="Laverne", LastName="Wolfe", Major="CIS", Email="lwolfe@buffs.wtamu.edu", Phone="555-555-5555", Standing = "Senior" },
                    new Member { FirstName="Delia", LastName="Bridges", Major="CIS", Email="dbridges@buffs.wtamu.edu", Phone="555-555-5555", Standing = "Senior" },
                    new Member { FirstName="Rebecca", LastName="Morton", Major="CIS", Email="rmorton@buffs.wtamu.edu", Phone="555-555-5555", Standing = "Junior" },
                    new Member { FirstName="Bream", LastName="McGregger", Major="CIS", Email="bgregger@buffs.wtamu.edu", Phone="555-555-5555", Standing = "Junior" },
                    new Member { FirstName="Franklin", LastName="Arnold", Major="CIS", Email="farnold@buffs.wtamu.edu", Phone="555-555-5555", Standing = "Senior" },
                    new Member { FirstName="Jeff", LastName="Jackson", Major="CIS", Email="jjackson@buffs.wtamu.edu", Phone="555-555-5555", Standing = "Junior" },
                    new Member { FirstName="Tim", LastName="Johnson", Major="CIS", Email="tjohnson@buffs.wtamu.edu", Phone="555-555-5555", Standing = "Junior" },
                };
                context.AddRange(members);
                context.SaveChanges();

                // PROJECTS
                if (context.Projects.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                var projects = new List<Project>
                {
                    new Project { ProjectName="The Big One", Details="The One Project to rule them all" },
                    new Project { ProjectName="Awesome", Details="This project is awesome" },
                    new Project { ProjectName="Easy Project", Details="This project is so easy, it completes itself" }
                };
                context.AddRange(projects);
                context.SaveChanges();

                //PROJECT ROSTER BRIDGE TABLE - THERE MUST BE PROJECTS AND PARTICIPANTS MADE FIRST
                if (context.ProjectRoster.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                

                //quickly grab the recent records added to the DB to get the IDs
                var projectsFromDb = context.Projects.ToList();
                var clientsFromDb = context.Clients.ToList();
                var membersFromDb = context.Members.ToList();

                var projectroster = new List<ProjectRoster>
                {
                    //take the first project from above, the first client from above, and the first three students from above.
                    new ProjectRoster { ProjectID = projectsFromDb.ElementAt(0).ID.ToString(), 
                                        Project = projectsFromDb.ElementAt(0), 
                                        ProjectParticipantID = clientsFromDb.ElementAt(0).ID.ToString(),
                                        ProjectParticipant = clientsFromDb.ElementAt(0) },

                    new ProjectRoster { ProjectID = projectsFromDb.ElementAt(0).ID.ToString(), 
                                        Project = projectsFromDb.ElementAt(0), 
                                        ProjectParticipantID = membersFromDb.ElementAt(0).ID.ToString(),
                                        ProjectParticipant = membersFromDb.ElementAt(0) },

                    new ProjectRoster { ProjectID = projectsFromDb.ElementAt(0).ID.ToString(), 
                                        Project = projectsFromDb.ElementAt(0), 
                                        ProjectParticipantID = membersFromDb.ElementAt(1).ID.ToString(),
                                        ProjectParticipant = membersFromDb.ElementAt(1) },

                    new ProjectRoster { ProjectID = projectsFromDb.ElementAt(0).ID.ToString(), 
                                        Project = projectsFromDb.ElementAt(0), 
                                        ProjectParticipantID = membersFromDb.ElementAt(2).ID.ToString(),
                                        ProjectParticipant = membersFromDb.ElementAt(2) },                                        
                };
                context.AddRange(projectroster);
                context.SaveChanges();                

            }
        }
    }
}