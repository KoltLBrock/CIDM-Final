using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BuffteksWebsite.Models{
    public class ProjectParticipant {
        public int ID {get; set;}
        [Display(Name = "First Name")]
        public string FirstName {get; set;}
        [Display(Name = "Last Name")]
        public string LastName {get; set;}
        public ICollection<ProjectRoster> Projects {get; set;}
    }
}