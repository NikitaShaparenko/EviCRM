using EviCRM.Core.Db.Interfaces;
namespace EviCRM.Core.Db.Entities.Core
{
    public class Attachments : IMetaFiller
    {
        public Guid Id { get; set; }

        public string Path { get; set; }

        public string Cluster { get; set; }

        public string Name { get; set; }

        public AttachmentsSourceEnum Sender { get; set; }

        /// <summary>
        /// Когда была добавлена запись
        /// </summary>
        public DateTime? WhenInserted { get; set; }

        /// <summary>
        /// Когда была обновлена запись
        /// </summary>
        public DateTime? WhenUpdated { get; set; }

        /// <summary>
        /// Кто добавил запись
        /// </summary>
        public Guid? WhoInserted { get; set; }

        /// <summary>
        /// Кто отредактировал запись
        /// </summary>
        public Guid? WhoUpdated { get; set; }

        public string GetFullPathToFile()
        {
            return "/";
        }

    }

    public enum AttachmentsSourceEnum
    {
        Integration,
        Calendar,
        Chat,
        Tasks,
        Projects,
        Alexandra,
    }
}
