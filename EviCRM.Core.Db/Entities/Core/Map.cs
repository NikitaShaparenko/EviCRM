using EviCRM.Core.Db.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace EviCRM.Core.Db.Entities.Core
{
    public class Map : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Местоположение
        /// </summary>
        [Column(TypeName = "geography (point)")]
        public Point Location { get; set; }

        /// <summary>
        /// Описание точки на карте
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Пользователь, добавивший точку на карту
        /// </summary>
        public User? Author { get; set; }

         /// <summary>
         /// 
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
