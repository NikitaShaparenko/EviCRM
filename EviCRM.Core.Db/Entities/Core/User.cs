using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
    public class User : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Токен входа OAuth пользователя
        /// </summary>
        public string? Token { get; set; }

        /// <summary>
        /// Временной токен входа OAuth пользователя
        /// </summary>
        public string? TimeToken { get; set; }

        /// <summary>
        /// Полное имя пользователя
        /// </summary>
        public string Fullname { get; set; }

        /// <summary>
        /// Компания, в которой состоит пользователь
        /// </summary>
        public Company? Company { get; set; }

        /// <summary>
        /// Должность, на которой работает пользователь
        /// </summary>
        public Position? Position { get; set; }

        /// <summary>
        /// Подразделение, в котором работает пользователь
        /// </summary>
        public Department? Department { get; set; }

        /// <summary>
        /// Отдел, в котором работает пользователь
        /// </summary>
        public Division? Division { get; set; }

        /// <summary>
        /// Навыки пользователя
        /// </summary>
        public List<Guid>? Skills { get; set; }

        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public string? MobilePhoneNumber { get; set; }

        /// <summary>
        /// Внешний ключ связи таблиц User и Task для отвественного пользователя в задаче
        /// </summary>
        //public List<Task>? FKResponsibleMembersToTasksBound { get; set; }

        /// <summary>
        /// Внешний ключ связи таблиц User и Task для пользователей в задаче
        /// </summary>
       // public List<Task>? FKMembersToTasksBound { get; set; }

        /// <summary>
        /// Внешний ключ связи таблиц User и Task для пользователей в задаче и автора задачи
        /// </summary>
       // public Task? FKAuthorToTaskBound{ get; set; }

        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Опыт работы, 1 абзац
        /// </summary>
        public string? ExperienceS1 { get; set; }

        /// <summary>
        /// Опыт работы, 2 абзац
        /// </summary>
        public string? ExperienceS2 { get; set; }

        /// <summary>
        /// Объём общей выручки
        /// </summary>
        public double? TotalRevenue { get; set; }

        /// <summary>
        /// Выручка пользователя
        /// </summary>
        public double? Revenue { get; set; }

        /// <summary>
        /// День рождения
        /// </summary>
        public DateTime? BirthDay { get; set; }

        /// <summary>
        /// Дата и время последнего входа
        /// </summary>
        public DateTime? LastLogin { get; set; }

        /// <summary>
        /// Дата и время последнего действия
        /// </summary>
        public DateTime? LastAction { get; set; }

        /// <summary>
        /// Дата и время последней активности
        /// </summary>
        public DateTime? LastActivity { get; set; }

        /// <summary>
        /// Описание пользователя (био)
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Связь с профилем в Телеграм
        /// </summary>
        public Telegram? Telegram { get; set; }

        /// <summary>
        /// Роль пользователя
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// Флаг "Активирован". Да - Активирован, Нет - не активирован
        /// </summary>
        public bool IsActivated { get; set; }

        /// <summary>
        /// Аватарка пользователя
        /// </summary>
        public Avatar? Avatar { get; set; }

        /// <summary>
        /// Связь пользователя с тонким клиентом
        /// </summary>
        public string? ThinClientUsing { get; set; }

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
