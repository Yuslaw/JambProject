using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using JambRegProject.Contxt;

namespace JambRegProject.Repositories
{
    public class BaseRepository<T> where T : class
    {
        public ApplicationDbContext Context { get; set; }


        public BaseRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public T Create(T obj)
        {
            Context.Set<T>().Add(obj);
            Context.SaveChanges();
            return obj;
        }
        public T Update(T obj)
        {
            Context.Set<T>().Update(obj);
            Context.SaveChanges();
            return obj;

        }
        public bool Delete(int id)
        {
            var s = Context.Set<T>().Find(id);
            if (s == null) return false;
            Context.Set<T>().Remove(s);
            Context.SaveChanges();
            return true;
        }


        public T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {

            return Context.Set<T>().FirstOrDefault(expression);
        }


        public List<T> GetMany(Expression<Func<T, bool>> expression)
        {

            return Context.Set<T>().Where(expression).ToList();
        }

    }

}