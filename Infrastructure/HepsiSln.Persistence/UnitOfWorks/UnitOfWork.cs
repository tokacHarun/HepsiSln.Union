﻿using HepsiSln.Application.Interfaces.Repostories;
using HepsiSln.Application.Interfaces.UnitOfWorks;
using HepsiSln.Persistence.Context;
using HepsiSln.Persistence.Repostories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CommitAsync()
        {
            await dbContext.Database.CommitTransactionAsync();
        }

        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();

        public async Task OpenTransactionAsync()
        {
            await dbContext.Database.OpenConnectionAsync();
        }

        public async Task RollBackAsync()
        {
            await dbContext.Database.RollbackTransactionAsync();
        }

        public int Save() => dbContext.SaveChanges();


        public async Task<int> SaveAsync() => await dbContext.SaveChangesAsync();



        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(dbContext);


        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(dbContext);

    }
}
