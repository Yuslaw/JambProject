using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JambRegProject.Model
{
    public class Course
    {
        public int id {get; set;}
        public string CourseName{get; set;}
        public  List<StudentCourse> StudentCourses {get; set;}
        public  List<SchoolCourse> SchoolCourses {get; set;}
      
        
    }
}