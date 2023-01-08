using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace EviCRM.Core.Db.Entities.Core.Markdown
{
    [Table("MarkdownTodo")]
    public class Todo : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Связанная с делом задача
        /// </summary>
        public Task TaskBound { get; set; }

        /// <summary>
        /// Флаг "Дело отмечено выполненным"
        /// </summary>
        public bool IsChecked { get; set; }

        /// <summary>
        /// Текст дела
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Связанная с делом карточка MarkDown
        /// </summary>
        public Card CardBound { get; set; }

        /// <summary>
        /// Дата и время отметки
        /// </summary>
        public DateTime? MarkEvent { get; set; }

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
