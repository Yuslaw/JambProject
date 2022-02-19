using System;
using JambRegProject.Enums;

namespace JambRegProject.Model
{
    public class StudentCourse
    {
        public int Id {get; set;}
        public int CourseId {get; set;}
        public Course Course  {get; set;}
        public int StudentId {get; set;}
        public Student Student {get; set;}
       

    }
}