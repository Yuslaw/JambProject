using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JambRegProject.Model
{
    public class School
    {
        public int id {get; set;}
        public string SchoolName{get; set;}
        public  virtual List<StudentSchool> StudentSchools {get; set;} = new List<StudentSchool>();
        public  virtual List<SchoolCourse> SchoolCourses {get; set;} = new List<SchoolCourse>();

       
    }
}