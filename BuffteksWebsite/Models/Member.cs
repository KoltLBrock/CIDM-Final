using System;

namespace BuffteksWebsite.Models
{
    public class Member
    {
        public int ID {get; set;}
        public string MemberUserName { get; set; }
        public string FirstName { get; set;}
        public string LastName {get; set;}
        public string Standing {get; set;}
        public string Major {get; set;}
        public string Birthday{ get; set; }
        public string Email{ get; set; }
        public string Phone{ get; set; }
    }
}