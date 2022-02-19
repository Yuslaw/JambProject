using JambRegProject.Enums;

namespace JambRegProject.Model
{
    public class StudentSchool
    {
        public int Id {get; set;}
        public int StudentId {get; set;}
        public Student Student {get; set;}
        public int SchoolId {get; set;}
        public School School {get; set;}
       
        
    }
}