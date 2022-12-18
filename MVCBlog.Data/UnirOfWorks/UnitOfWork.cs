using Microsoft.EntityFrameworkCore.Diagnostics;
using MVCBlog.Core.Entities;
using MVCBlog.Data.Context;
using MVCBlog.Data.Repositories.Abstractions;
using MVCBlog.Data.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlog.Data.UnirOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async ValueTask DisposeAsync()
        {
            await dbContext.DisposeAsync();
        }

        public IRepository<T> GetRepository<T>() where T : class,IEntityBase, new()
        {
            return new Repository<T>(dbContext);
        }

        public int Save()
        {
           return dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
}
