using EviCRM.Core.Db.Entities.Core.Markdown;
using EviCRM.Core.Db.Interfaces;
using EviCRM.Core.Db.Models;

namespace EviCRM.Core.Db.Entities.Core.TaskTracking
{
    public class Event : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Команда TOScript
        /// </summary>
        public ToScriptCommandEnum Command { get; set; }

        /// <summary>
        /// Значение основной переменной
        /// </summary>
        public string Variable1 { get; set; }

        /// <summary>
        /// Значение дополнительной переменной 1
        /// </summary>
        public string? Variable2 { get; set; }

        /// <summary>
        /// Значение дополнительной переменной 2
        /// </summary>

        public string? Variable3 { get; set; }

        /// <summary>
        /// Значение дополнительной переменной 3
        /// </summary>

        public string? Variable4 { get; set; }

        /// <summary>
        /// Значение дополнительной переменной 4
        /// </summary>
        /// 
        public string? Variable5 { get; set; }

        /// <summary>
        /// Автор команды
        /// </summary>
        public User Author { get; set; }

        //Связанная задача

        public Task TaskBound { get; set; }

        //Связанная карточка Markdown

        public Card? CardBound { get; set; }

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
