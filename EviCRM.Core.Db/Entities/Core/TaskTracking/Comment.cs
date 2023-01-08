using EviCRM.Core.Db.Interfaces;

namespace EviCRM.Core.Db.Entities.Core.TaskTracking
{
    public class Comment : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Автор комментария
        /// </summary>
        public User Author { get; set; }

        /// <summary>
        /// Исходное событие, к которому оставлен комментарий
        /// </summary>
        public Event SourceEvent { get; set; }

        /// <summary>
        /// Комментарий в ответ на комментарий
        /// </summary>
        public Guid? InReplyCommentId { get; set; }

        /// <summary>
        /// Тело комментария
        /// </summary>
        public string Body { get; set; }

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
