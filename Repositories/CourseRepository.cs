using JambRegProject.Contxt;
using JambRegProject.Model;

namespace JambRegProject.Repositories
{
    public class CourseRepository : BaseRepository<Course>
    {
        public CourseRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}