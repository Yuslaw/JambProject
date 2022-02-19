using JambRegProject.Contxt;
using JambRegProject.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace JambRegProject.Repositories
{
    public class StudentRepository : BaseRepository<Student>
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {


        }

        public List<Student> GetStudentsByCenter(int id) => Context.Students.Where(s => s.Centerid == id).ToList();

        public List<Student> GetStudentsBySubjectId(int subjectId)
        {
            return Context.StudentSubjects
                .Where(s => s.Subjectid == subjectId)
                .Select(ss => ss.Student).ToList();
        }

    }
}