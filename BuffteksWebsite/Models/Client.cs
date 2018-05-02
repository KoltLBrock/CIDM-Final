using System;
using System.ComponentModel.DataAnnotations;
namespace BuffteksWebsite.Models
{
    public class Client : ProjectParticipant
    {
        [Display(Name = "User Name")]
        public string ClientUserName { get; set; }
        [Display(Name = "Company Name")] 
        public string CompanyName {get; set;}
    }
}