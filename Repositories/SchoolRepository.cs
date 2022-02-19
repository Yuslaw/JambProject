using System.Collections.Generic;
using System.Linq;
using JambRegProject.Contxt;
using JambRegProject.Model;

namespace JambRegProject.Repositories
{
    public class SchoolRepository : BaseRepository<School>
    {
        public SchoolRepository(ApplicationDbContext context) : base(context)
        {
            
        }

           public List<Course> GetCoursesBySchoolId(int schoolId)
        {
            return Context.SchoolCourses
            .Where(s => s.SchoolId == schoolId)
            .Select(ss => ss.Course).ToList();
        }

    }
}