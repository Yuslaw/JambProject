using System;
using System.Collections.Generic;
using System.Linq;
using JambRegProject.Contxt;
using JambRegProject.Model;

namespace JambRegProject.Repositories
{
    public class CenterRepository : BaseRepository<Center>
    {
        public CenterRepository(ApplicationDbContext context) : base(context)
        {
        }

        
    }
}