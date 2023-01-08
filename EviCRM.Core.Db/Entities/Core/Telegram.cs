using EviCRM.Core.Db.Interfaces;
using EviCRM.Core.Db.Models;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
    public class Telegram : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// ChatId c выбранным пользователем
        /// </summary>
        public string ChatId { get; set; }

        /// <summary>
        /// Статус связи сущности пользователя и Александрой
        /// </summary>
        public TelegramSyncStatusEnum Status { get; set; }

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
