using System;
using System.ComponentModel.DataAnnotations;
namespace BuffteksWebsite.Models
{
    public class Client : ProjectParticipant
    {
        [Display(Name = "Company Name")] 
        public string CompanyName {get; set;}
    }
}