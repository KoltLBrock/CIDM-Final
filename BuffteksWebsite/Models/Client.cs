using System;

namespace BuffteksWebsite.Models
{
    public class Client
    {
        public int ID {get; set;}
        public string ClientUserName { get; set; }
        public string FirstName { get; set;}
        public string LastName {get; set;}
        public string Email{ get; set; }
        public string Phone{ get; set; }
    }
}