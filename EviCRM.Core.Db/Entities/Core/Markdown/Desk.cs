using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace EviCRM.Core.Db.Entities.Core.Markdown
{
    [Table("MarkdownDesk")]
    public class Desk : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя доски
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Связанный пользователь с доской
        /// </summary>
        public User? PersonalBound { get; set; }

        /// <summary>
        /// Флаг публичности доски (да - персональная доска, нет - публичная)
        /// </summary>
        public bool IsPersonal { get; set; }

        /// <summary>
        /// Связанная с доской задача
        /// </summary>
        public Task TaskBound { get; set; }

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
