using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace EviCRM.Core.Db.Entities.Core.Markdown
{
    [Table("MarkdownCard")]
    public class Card : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя карточки Markdown
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание карточки Markdown
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Дата и время начала карточки Markdown
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата и время окончания карточки Markdown
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Обложка карточки
        /// </summary>
        public Attachment? TitleImage { get; set; }

        /// <summary>
        /// Задний цвет карточки в HEX
        /// </summary>
        public string? BackColorHex { get; set; }

        /// <summary>
        /// Связанная задача с карточкой
        /// </summary>
        public Task TaskBound { get; set; }

        /// <summary>
        /// Связанная доска с карточкой
        /// </summary>
        public Desk DeskBound { get; set; }

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
