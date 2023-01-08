using EviCRM.Core.Db.Interfaces;
using EviCRM.Core.Db.Models;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
    public class PersonalStatus : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Связанная с персональным статусом задача
        /// </summary>
        public Task BoundTask { get; set; }

        /// <summary>
        /// Персональный статус выполнения задачи
        /// </summary>
        public PersonalStatusEnum Status { get; set; }

        /// <summary>
        /// Пользователь с персональным статусом
        /// </summary>
        public User User { get; set; }

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
