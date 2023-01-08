using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
    public class Attachment : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Локальный путь к вложению
        /// </summary>
        public string? LocalPath { get; set; }

        /// <summary>
        /// Сетевой путь к вложению
        /// </summary>
        public string? NetworkPath { get; set; }

        /// <summary>
        /// Имя загруженного файла
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Источник загруженного файла
        /// </summary>
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
