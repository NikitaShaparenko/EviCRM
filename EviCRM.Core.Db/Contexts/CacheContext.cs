﻿using EviCRM.Core.Db.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EviCRM.Core.Db.Contexts
{
    public partial class CacheContext : DbContext
    {
        private readonly ICurrentUser _currentUser;

        public CacheContext(ICurrentUser currentUser = default)
        {
            _currentUser = currentUser;
        }

        public CacheContext(DbContextOptions<CacheContext> options, ICurrentUser currentUser = default) : base(options)
        {
            _currentUser = currentUser;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");


        }
    }
}
