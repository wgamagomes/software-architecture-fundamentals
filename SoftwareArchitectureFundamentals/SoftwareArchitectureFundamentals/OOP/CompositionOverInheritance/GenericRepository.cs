﻿namespace SoftwareArchitectureFundamentals.OOP.CompositionOverInheritance
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class, new()
    {
        public void Add(TEntity entity)
        {
           
        }

        public void Remove(TEntity entity)
        {
           
        }
    }
}
