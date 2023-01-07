using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EviCRM.Core.Db.Interfaces;

namespace EviCRM.Core.Db.Entities.Alexandra
{
    public class Locations : IMetaFiller
    {
        public Guid Id { get; set; }

        public string Lat { get; set; }

        public string Lng { get; set; }

        public string Name { get; set; }

        public User User { get; set; }

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
