using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
    public class WorkingDays : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Подопытный пользователь
        /// </summary>
        public User? SubjectUser { get; set; }

        /// <summary>
        /// Дата активности
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Время начала работы
        /// </summary>
        public DateTime? StartWork { get; set; }

        /// <summary>
        /// Время окончания работы
        /// </summary>
        public DateTime? EndWork { get; set; }
       
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
