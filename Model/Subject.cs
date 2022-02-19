using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JambRegProject.Enums;
namespace JambRegProject.Model
{
    public class Subject
    {
        
        public int id {get; set;}
        public string SubjectName{get; set;}
        
        public virtual List<StudentSubject> Studentsubject {get; set;} = new List<StudentSubject>();
        
     
       

     
        
    }
}