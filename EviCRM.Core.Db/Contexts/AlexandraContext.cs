using EviCRM.Core.Db.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EviCRM.Core.Db.Contexts
{
    public partial class AlexandraContext : DbContext
    {
        private readonly ICurrentUser _currentUser;

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


        }
    }
}
