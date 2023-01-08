using System.ComponentModel.DataAnnotations.Schema;
using EviCRM.Core.Db.Entities.Core;
using EviCRM.Core.Db.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NetTopologySuite.Geometries;

namespace EviCRM.Core.Db.Entities.Alexandra
{
    public class Map : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Точка на карте
        /// </summary>
        [Column(TypeName = "geography")]
        public Point Location { get; set; }

        /// <summary>
        /// Название точки на карте
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Пользователь, добавивший точку
        /// </summary>
        public Guid? User { get; set; }

        /// <summary>
        /// Флаг публичности точки, если да - отображается у всех
        /// </summary>
        public bool IsPublic { get; set; }

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
