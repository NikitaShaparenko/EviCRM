using EviCRM.Core.Db.Entities.Core;
using EviCRM.Core.Db.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EviCRM.Core.Db.Contexts
{
    public partial class CoreContext : DbContext
    {
        private readonly ICurrentUser _currentUser;
        public DbSet<Attachment> Attachment { get; set; }
        public DbSet<Avatar> Avatar { get; set; }
        public DbSet<Calendar> Calendar { get; set; }
        public DbSet<CalendarVisual> CalendarVisual { get; set; }
        public DbSet<Chat> Chat { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<Health> Health { get; set; }
        public DbSet<KeyStore> KeyStore { get; set; }
        public DbSet<Map> Map { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsCat> NewsCat { get; set; }
        public DbSet<NewsComment> NewsComment { get; set; }
        public DbSet<NewsTag> NewsTag { get; set; }
        public DbSet<PersonalStatus> PersonalStatus { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Entities.Core.Task> Task { get; set; }
        public DbSet<Telegram> Telegram { get; set; }
        public DbSet<TelegramPush> TelegramPush { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<WorkingDays> WorkingDays { get; set; }
        public DbSet<Entities.Core.Markdown.Card> MarkdownCard { get; set; }
        public DbSet<Entities.Core.Markdown.Desk> MarkdownDesk { get; set; }
        public DbSet<Entities.Core.Markdown.Todo> MarkdownTodo { get; set; }
        public DbSet<Entities.Core.TaskTracking.Comment> TaskTrackingComment { get; set; }
        public DbSet<Entities.Core.TaskTracking.Event> TaskTrackingEvent { get; set; }

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
            modelBuilder.HasPostgresExtension("postgis");

            modelBuilder.Entity<Map>()
                .Property(_ => _.Location)
                .HasColumnType("geography (point)");
        }
    }
}
