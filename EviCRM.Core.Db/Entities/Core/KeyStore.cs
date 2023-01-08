using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
    public class KeyStore : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Команда
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// Значение переменной 1
        /// </summary>
        public string? Value1 { get; set; }

        /// <summary>
        /// Значение переменной 2
        /// </summary>
        public string? Value2 { get; set; }

        /// <summary>
        /// Значение переменной 3
        /// </summary>
        public string? Value3 { get; set; }

        /// <summary>
        /// Значение переменной 4
        /// </summary>
        public string? Value4 { get; set; }

        /// <summary>
        /// Значение переменной 5
        /// </summary>
        public string? Value5 { get; set; }

        /// <summary>
        /// Значение переменной 6
        /// </summary>
        public string? Value6 { get; set; }

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
