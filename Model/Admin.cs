using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JambRegProject.Enums;

namespace JambRegProject.Model
{
    public class Admin
    {
        
        public int Id {get; set;}
        public string AdminId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get;set;}
        public Gender Gender {get;set;}
        public string Email{get;set;}
        public string PhoneNum {get;set;}
        public string Address {get; set;}
        public int Age {get; set;}
        public int Pin {get; set;}

        
          
    }
}