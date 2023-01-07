using EviCRM.Core.Db.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EviCRM.Core.Db.Contexts
{
    public partial class IntegrationContext : DbContext
    {
        private readonly ICurrentUser _currentUser;

        public IntegrationContext(ICurrentUser currentUser = default)
        {
            _currentUser = currentUser;
        }

        public IntegrationContext(DbContextOptions<IntegrationContext> options, ICurrentUser currentUser = default) : base(options)
        {
            _currentUser = currentUser;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");


        }
    }
}
