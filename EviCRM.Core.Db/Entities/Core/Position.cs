using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
    public class Position : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Название должности
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Компания, к которой привязана должность
        /// </summary>
        public Company? Company { get; set; }

        /// <summary>
        /// Отедл, к которому привязана должность
        /// </summary>
        public Division? Division { get; set; }

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

    }
}
