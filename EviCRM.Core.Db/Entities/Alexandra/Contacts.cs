using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EviCRM.Core.Db.Interfaces;

namespace EviCRM.Core.Db.Entities.Alexandra
{
    public class Contacts : IMetaFiller
    {

        public Guid Id { get; set; }

        public string? firstname { get; set; }

        public string? lastname { get; set; }

        public string? phonenumber { get; set; }

        public string? userId { get; set; }

        public string? vcard { get; set; }

        public string? login { get; set; } 
        
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
