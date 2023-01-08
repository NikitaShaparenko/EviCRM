using EviCRM.Core.Db.Entities.Alexandra;
using EviCRM.Core.Db.Entities.Core;
using EviCRM.Core.Db.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EviCRM.Core.Db.Contexts
{
    public partial class AlexandraContext : DbContext
    {
        private readonly ICurrentUser _currentUser;

        public DbSet<Contact> Contact { get; set; }
        public DbSet<Poll> Poll { get; set; }
        public DbSet<Entities.Alexandra.Map> Map { get; set; }

        public AlexandraContext(ICurrentUser currentUser = default)
        {
            _currentUser = currentUser;
        }

        public AlexandraContext(DbContextOptions<AlexandraContext> options, ICurrentUser currentUser = default) : base(options)
        {
            _currentUser = currentUser;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");
            modelBuilder.HasPostgresExtension("postgis");
            modelBuilder.Entity<Entities.Alexandra.Map>().Property(b => b.Location).HasColumnType("geography (point)");

        }
    }
}
