using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Productivity.Data
{
    public interface IRepository<T>
    {
        DbContext Context { get; }
        int Count { get; }
        IEnumerable<T> All { get; }
        void Add(ref T value);
        void Edit(ref T value);
        void Remove(ref T value);
    }
}