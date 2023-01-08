using EviCRM.Core.Db.Interfaces;
using EviCRM.Core.Db.Models;

namespace EviCRM.Core.Db.Entities.Alexandra
{
    public class Contact : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string? Lastname { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string? MobilePhoneNumber { get; set; }

        /// <summary>
        /// Связанный пользователь
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// Статус связи сущности пользователя и Александрой
        /// </summary>
        public TelegramSyncStatusEnum Status { get; set; }

        /// <summary>
        /// Данные VCard контакта
        /// </summary>
        public string? VCard { get; set; }

        /// <summary>
        /// Логин в Телеграмме
        /// </summary>
        public string? Login { get; set; } 
        
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
