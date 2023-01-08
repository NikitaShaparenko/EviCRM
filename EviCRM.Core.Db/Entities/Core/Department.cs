using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EviCRM.Core.Db.Entities.Core
{
    public class Department : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Название подразделения
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Глава подразделения
        /// </summary>
        public Guid? Head { get; set; }

        /// <summary>
        /// Аватарка подразделения
        /// </summary>
        public Avatar? Avatar { get; set; }

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
