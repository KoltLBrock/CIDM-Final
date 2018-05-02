using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuffteksWebsite.Models
{
    public class Project
    {
        [Key]
        public string ID {get; set;}
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }
        [Display(Name = "Project Description")] 
        public string Details {get; set;}
        public ICollection<ProjectRoster> Participants { get; set; }
        
        /*
        public override string ToString(){
            return $"Project Name: {this.ProjectName}\nProject Description: {this.ProjectDescription}";
        }
         */
    }
}