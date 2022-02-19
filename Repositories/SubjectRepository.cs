using JambRegProject.Contxt;
using JambRegProject.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace JambRegProject.Repositories
{
    public class SubjectRepository : BaseRepository<Subject>
    {
        public SubjectRepository(ApplicationDbContext context) : base(context)
        {
            
        }
        public List<Subject> GetSubjectByStudentId(int studentId) 
        {
            return Context.StudentSubjects
               .Where(s => s.Studentid == studentId)
               .Select(ss => ss.Subject).ToList();


        }

    }
}