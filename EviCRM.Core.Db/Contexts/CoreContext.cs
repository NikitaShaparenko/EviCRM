using EviCRM.Core.Db.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EviCRM.Core.Db.Contexts
{
    public partial class CoreContext : DbContext
    {
        private readonly ICurrentUser _currentUser;

        public CoreContext(ICurrentUser currentUser = default)
        {
            _currentUser = currentUser;
        }

        public CoreContext(DbContextOptions<CoreContext> options, ICurrentUser currentUser = default) : base(options)
        {
            _currentUser = currentUser;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");


        }
    }
}
