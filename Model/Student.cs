using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JambRegProject.Enums;

namespace JambRegProject.Model
{
    public class Student
    {
        public int Id {get; set;}
        public string JambRegNo {get; set;}
        public string FirstName {get; set;}
        public string LastName {get;set;}
        public Gender Gender {get;set;}
        public string Email{get;set;}
        public string PhoneNum {get;set;}
        public string Address {get; set;}
        public int Age {get; set;}
        public int Pin {get; set;}
        public int Centerid {get; set;}
        public Center Center {get; set;}
       
     
       
       public string DateOfExam {get; set;}
      
       public List<StudentSubject> Studentsubject {get; set;}
       public  List<StudentCourse> StudentCourses {get; set;}
       public  List<StudentSchool> StudentSchools {get; set;}
    
   


    }
}