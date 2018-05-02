using System;
using System.ComponentModel.DataAnnotations;

namespace BuffteksWebsite.Models
{
    public class Member : ProjectParticipant
    {
        public string Standing {get; set;}
        public string Major {get; set;}
    }
}