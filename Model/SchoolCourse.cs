using JambRegProject.Enums;

namespace JambRegProject.Model
{
    public class SchoolCourse
    {
        public int Id {get; set;}
       
        public int CourseId {get; set;}
        public Course Course  {get; set;}
        public int SchoolId {get; set;}
        public School School {get; set;}
        
        
    }
}