using EviCRM.Core.Db.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EviCRM.Core.Db.Entities.Cache
{
    public class MainCluster : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Строковое значение 1
        /// </summary>
        [Column(TypeName = "jsonb")]
        public string? StringVariable1 { get; set; }

        /// <summary>
        /// Строковое значение 2
        /// </summary>
        [Column(TypeName = "jsonb")]
        public string? StringVariable2 { get; set; }

        /// <summary>
        /// Строковое значение 3
        /// </summary>
        [Column(TypeName = "jsonb")]
        public string? StringVariable3 { get; set; }

        /// <summary>
        /// Строковое значение 4
        /// </summary>
        [Column(TypeName = "jsonb")]
        public string? StringVariable4 { get; set; }

        /// <summary>
        /// Строковое значение 5
        /// </summary>
        [Column(TypeName = "jsonb")]
        public string? StringVariable5 { get; set; }

        /// <summary>
        /// Общий внешний ключ
        /// </summary>
        public string? CommonExternalKey { get; set; }

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
