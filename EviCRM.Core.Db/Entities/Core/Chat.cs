using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
    public class Chat : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Название чата
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Аватар чата
        /// </summary>
        public Avatar? Avatar { get; set; }

        /// <summary>
        /// Флаг "Персональный\Групповой чат". 
        /// Если да - чат только для двоих. 
        /// Если нет - групповой чат
        /// </summary>
        public bool IsPersonal { get; set; }

        /// <summary>
        /// Флаг "Секретный\Публичный чат"
        /// Если да - чат не сохраняется в истории сообщений
        /// Если нет - сохраняется
        /// </summary>
        public bool IsSecret { get; set; }

        /// <summary>
        /// Состав участников чата
        /// </summary>
        List<Guid>? Cast { get; set; }
        
        /// <summary>
        /// Ключ шифрования
        /// </summary>
        public string Key { get; set; }

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
