using System;
using System.Collections.Generic;

namespace userDashboard.Models
{
    public class Message : BaseEntity
    {
        public int MessageId {get;set;}

        public string MessageData {get;set;}

        public DateTime Date {get;set;}

        public int UserId {get;set;}

        public User User {get;set;}
        public List<Comment> Comments{get;set;}
        public Message()
        {
            Comments = new List<Comment>();
        }
    }
}