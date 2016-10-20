using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Productivity.Models;
using Productivity.Persistence;

namespace Productivity.Data
{
    public class Personen : Repository<Employee>
    {
        public Personen(DatabaseContext ctx) : base(ctx)
        {
            
        }
    }
    public class Arbeit : Repository<IAuftrag>
    {
        public override IEnumerable<IAuftrag> All => Enumerable.Concat<IAuftrag>(Context.Set<Umbau>(), Context.Set<Neubau>());
        public override int Count => Context.Set<Umbau>().Count() + Context.Set<Neubau>().Count();

        public Arbeit(DatabaseContext ctx) : base(ctx)
        {
            
        }

        public override void Add(ref IAuftrag value)
        {
            if (value is Umbau)
            {
                Context.Set<Umbau>().Add((Umbau) value);
            }
            else if (value is Neubau)
            {
                Context.Set<Neubau>().Add((Neubau) value);
            }
            else return;
            Context.SaveChanges();
        }
        public void AddGeneric<T>(ref T value) where T : IAuftrag
        {
            IAuftrag auftrag = value;
            Add(ref auftrag);
        }

        public override void Edit(ref IAuftrag value)
        {
            if (value is Umbau)
            {
                Context.Entry<Umbau>((Umbau)value).State = EntityState.Modified;
            }
            else if (value is Neubau)
            {
                Context.Entry<Neubau>((Neubau)value).State = EntityState.Modified;
            }
            else return;
            Context.SaveChanges();
        }
        public void EditGeneric<T>(ref T value) where T : IAuftrag
        {
            IAuftrag auftrag = value;
            Edit(ref auftrag);
        }
        public override void Remove(ref IAuftrag value)
        {
            if (value is Umbau)
            {
                Context.Set<Umbau>().Remove((Umbau) value);
            }
            else if (value is Neubau)
            {
                Context.Set<Neubau>().Remove((Neubau) value);
            }
            else return;
            Context.SaveChanges();
        }
        public void RemoveGeneric<T>(ref T value) where T : IAuftrag
        {
            IAuftrag auftrag = value;
            Remove(ref auftrag);
        }
    }
}