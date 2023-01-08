using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
    public class News : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Заголовок новости
        /// </summary>
        public string Headline { get; set; }

        /// <summary>
        /// Второй заголовок новости
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Тело новости
        /// </summary>
        public string? Body { get; set; }

        /// <summary>
        /// Теги к новости
        /// </summary>
        public List<Guid>? Tags { get; set; }

        /// <summary>
        /// Профильная картнка новости
        /// </summary>
        public Avatar? NewsAvatar { get; set; }

        /// <summary>
        /// Флаг "Новость перемещена в архив": Если "Да" - Новость в архиве
        /// </summary>
        public bool IsArchived { get; set; }

        /// <summary>
        /// Категория новости
        /// </summary>
        public NewsCat? Category { get; set; }

        /// <summary>
        /// Автор новости
        /// </summary>
        public User Author { get; set; }

        /// <summary>
        /// Упомянутые в новости отделы
        /// </summary>
        public List<Guid>? DivisionsMentioned { get; set; }

        /// <summary>
        /// Упомянутые в новости пользователи
        /// </summary>
        public List<User>? UsersMentioned { get; set; }
        
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
