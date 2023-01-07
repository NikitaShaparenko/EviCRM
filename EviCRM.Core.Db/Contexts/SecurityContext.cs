using EviCRM.Core.Db.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EviCRM.Core.Db.Contexts
{
    public partial class SecurityContext : DbContext
    {
        private readonly ICurrentUser _currentUser;

        public SecurityContext(ICurrentUser currentUser = default)
        {
            _currentUser = currentUser;
        }

        public SecurityContext(DbContextOptions<SecurityContext> options, ICurrentUser currentUser = default) : base(options)
        {
            _currentUser = currentUser;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");


        }
    }
}
