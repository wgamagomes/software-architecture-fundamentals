using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareArchitectureFundamentals.OOP.CompositionOverInheritance
{
    public interface IGenericRepository<TEntity>
        where TEntity: class, new ()
    {
        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
