using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
   public class Task : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Заголовок задачи
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание задачи
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Дата и время начала выполнения задачи
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата и время окончания выполнения задачи
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Фактическое окончание выполнения задачи
        /// </summary>
        public DateTime? FactEndDate { get; set; }
        
        /// <summary>
        /// Список вложений к задаче
        /// </summary>
        public List<Guid>? Attachments { get; set; }

        /// <summary>
        /// Бюджет задачи
        /// </summary>
        public string? Budget { get; set; }

        /// <summary>
        /// Состав участников задачи
        /// </summary>
        public List<Guid>? Members { get; set; }

        /// <summary>
        /// Статус выполнения задачи
        /// </summary>
        public TaskStatus Status { get; set; }

        /// <summary>
        /// Отвественные при выполнении задачи
        /// </summary>
        public List<Guid>? ResponsibleMembers { get; set; }

        /// <summary>
        /// Автор задачи
        /// </summary>
        public User Author { get; set; }

        /// <summary>
        /// Флаг "Оповещения об изменениях в задаче". Если "Да" - то Александра высылает оповещение, если "нет" - не высылает
        /// </summary>
        public bool IsNotify{ get; set; }

        /// <summary>
        /// Связанные с задачей проекты
        /// </summary>
        public List<Guid>? ProjectsBound { get; set; }

        /// <summary>
        /// Коллекция персональных статусов
        /// </summary>
        public List<Guid>? PersonalStatusCollection { get; set; }
        
        /// <summary>
        /// Отделы, связанные с задачей
        /// </summary>
        public List<Guid>? Divisions { get; set; }

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
