using EviCRM.Core.Db.Interfaces;
using EviCRM.Core.Db.Models;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
    public class Calendar : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key] 
        public Guid Id { get; set; }

        /// <summary>
        /// Идентификатор календаря
        /// </summary>
        public Guid CalendarId { get; set; }

        /// <summary>
        /// Начальная дата и время события
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата и время конца события
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Описания события
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Текст события
        /// </summary>
        public string? Body { get; set; }

        /// <summary>
        /// Флаг "В офисе": Да - в офисе, нет - вне офиса
        /// </summary>
        public bool IsInOffice { get; set; }

        /// <summary>
        /// Фоаг "Оповести меня": Да - Александра направит оповещение, нет - не отправит
        /// </summary>
        public bool IsNotify { get; set; }

        /// <summary>
        /// Период оповещения
        /// </summary>
        public CalendarNotifyPeriodEnum NotifyPeriod { get; set; }

        /// <summary>
        /// Служебный класс визуального отображения календаря
        /// </summary>
        public CalendarVisual VisualCalendarType { get; set; }
        
        /// <summary>
        /// Список приложений к событию
        /// </summary>
        public List<Guid?>? Attachments { get; set; }

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
