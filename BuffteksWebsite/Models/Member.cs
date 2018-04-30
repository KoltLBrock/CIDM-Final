using System;

namespace BuffteksWebsite.Models
{
    public class Member : ProjectParticiant
    {
        public string MemberUserName { get; set; }
        public string Standing {get; set;}
        public string Major {get; set;}
        public string Birthday{ get; set; }
        public string Email{ get; set; }
        public string Phone{ get; set; }
        /*
        public override string ToString(){
            return $"Member First Name: {this.FirstName} Member Last Name: {this.LastName}";
        }
         */
    }
}