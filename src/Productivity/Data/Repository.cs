using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Productivity.Data
{
    public class Repository<T> : IRepository<T>, IDisposable where T : class
    {
        public DbContext Context { get; }
        public virtual int Count => Context.Set<T>().Count();
        public virtual IEnumerable<T> All => Context.Set<T>();

        public Repository(DbContext context)
        {
            Context = context;
        }

        public virtual T Get(int i)
        {
            return Context.Set<T>().Skip(i).First();
        }

        public virtual void Add(ref T value)
        {
            Context.Set<T>().Add(value);
            Context.SaveChanges();
        }

        public virtual void Edit(ref T value)
        {
            Context.Entry(value).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public virtual void Remove(ref T value)
        {
            Context.Set<T>().Remove(value);
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
