using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
    public class NewsComment : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Новость, к которой привязан комменатрий
        /// </summary>
        public News NewsBound { get; set; }

        /// <summary>
        /// Пользователь, оставляющий комментарий
        /// </summary>
        public User Sender { get; set; }

        /// <summary>
        /// Флаг "Комментарий оставлен в ответ на комментарий". 
        /// Да - в ответ, Нет - комментарий корневой
        /// </summary>
        public bool InReply { get; set; }

        /// <summary>
        /// Комментарий, на который пользователь оставляет ответ
        /// </summary>
        public NewsComment? ReplyComment { get; set; }

        /// <summary>
        /// Текст комментария
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
