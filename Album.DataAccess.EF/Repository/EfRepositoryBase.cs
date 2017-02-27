using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Album.DataAccess.EF.Repository
{
    public class EfRepositoryBase<TContext, TEntity>
        where TContext : DbContext
        where TEntity : class, new()
    {
        public EfRepositoryBase(TContext context)
        {
           Context = context;


        }

        /// <summary>
        /// Instance of the DbContext. Must be passed or 
        /// injected.
        /// </summary>
        public TContext Context { get; set; }
    }
}
