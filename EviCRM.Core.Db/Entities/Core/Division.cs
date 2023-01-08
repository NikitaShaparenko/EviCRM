using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EviCRM.Core.Db.Entities.Core
{
    public class Division : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Название отдела
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Состав отдела
        /// </summary>
        public List<Guid> Cast { get; set; }

        /// <summary>
        /// Глава отдела
        /// </summary>
        public Guid? Head { get; set; }

        /// <summary>
        /// Аватарка отдела
        /// </summary>
        public Guid? Avatar { get; set; }

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
