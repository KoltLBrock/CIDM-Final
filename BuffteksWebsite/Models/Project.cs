using System;
using System.Collections.Generic;

namespace BuffteksWebsite.Models
{
    public class Project
    {
        public int ID {get; set;}
        public string ProjectName { get; set; }
        public string Details {get; set;}
        public List<ProjectParticiant> Participants {get; set;}
        /*
        public override string ToString(){
            return $"Project Name: {this.ProjectName}\nProject Description: {this.ProjectDescription}";
        }
         */
    }
}