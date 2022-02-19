using System;
using JambRegProject.Contxt;
using JambRegProject.Model;

namespace JambRegProject.Repositories
{
    public class AdminRepository : BaseRepository<Admin>
    {
        public AdminRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}