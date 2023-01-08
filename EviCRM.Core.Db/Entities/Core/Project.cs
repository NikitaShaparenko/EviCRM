using EviCRM.Core.Db.Interfaces;
using EviCRM.Core.Db.Models;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
    public class Project : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Название проекта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание проекта
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Детали проекта
        /// </summary>
        public string? Details { get; set; }

        /// <summary>
        /// Дата начала проекта
        /// </summary>
        public DateTime StartProject { get; set; }

        /// <summary>
        /// Дата оконания проекта
        /// </summary>
        public DateTime EndProject { get; set; }

        /// <summary>
        /// Список пользователей в проекте
        /// </summary>
        public List<Guid>? Cast { get; set; }

        /// <summary>
        /// Список отделов в проекте
        /// </summary>
        public List<Guid>? DivCast { get; set; }

        /// <summary>
        /// Статус проекта
        /// </summary>
        public ProjectStatusEnum Status { get; set; }
        
        /// <summary>
        /// Аватарка проекта
        /// </summary>
        public Avatar? Avatar { get; set; }

        /// <summary>
        /// Связанные задачи в проекте
        /// </summary>
        public List<Guid>? BoundTasks { get; set; }

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
