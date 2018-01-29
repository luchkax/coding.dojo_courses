using System;
using System.ComponentModel.DataAnnotations;
namespace bankAccount.Models
{
    public class Transaction : BaseEntity
    {   
        public int TransactionId{get;set;}
        public int UserId{get;set;}

        public User user{get;set;}
        
        public double? Amount{get;set;}
        public DateTime Date{get;set;}
    }
}