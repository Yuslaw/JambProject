using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JambRegProject.Enums;
namespace JambRegProject.Model
{
    public class StudentSubject
    {
        public int id {get; set;}
        public int Studentid {get; set;}
        public Student Student {get; set;}  
        public int Subjectid {get; set;}
        public Subject Subject {get; set;}   
          
    }
}