using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
    public class CalendarVisual : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Идентификатор календаря
        /// </summary>
        public string CalendarId { get; set; }

        /// <summary>
        /// Код календаря
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Цвет заметки в календаре
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Цвет надписей в календаре
        /// </summary>
        public string ForeColor { get; set; }

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
