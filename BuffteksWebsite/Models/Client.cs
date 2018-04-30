using System;
using System.ComponentModel.DataAnnotations;
namespace BuffteksWebsite.Models
{
    public class Client : ProjectParticipant
    {
        [Display(Name = "User Name")]
        public string ClientUserName { get; set; }
        public string Email{ get; set; }
        public string Phone{ get; set; }
        /*
        public override string ToString(){
            return $"Client First Name: {this.FirstName} Client Last Name: {this.LastName}";
        }
         */
    }
}