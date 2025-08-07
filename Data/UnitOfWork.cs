﻿using PlataformaEstagios.Domain;
using PlataformaEstagios.Infrastructure.Data;

namespace PlataformaEstagios.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public UnitOfWork(AppDbContext dbContext) => _dbContext = dbContext;

        public async Task Commit() => await _dbContext.SaveChangesAsync();
    }
}
