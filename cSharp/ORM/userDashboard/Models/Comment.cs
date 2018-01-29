using System;
using System.Collections.Generic;

namespace userDashboard.Models
{
    public class Comment : BaseEntity
    {
        public int CommentId {get;set;}

        public string CommentData {get; set;}

        public DateTime Date {get;set;}

        public int UserId{get;set;}

        public User User{get;set;}

        public int MessageId{get;set;}

        public Message Message{get;set;}

    }
}