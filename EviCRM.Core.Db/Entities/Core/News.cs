using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EviCRM.Core.Db.Interfaces;

namespace EviCRM.Core.Db.Entities.Core
{
    public class News : IMetaFiller
    {
        public Guid Id { get; set; }

        public string Headline { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public List<NewsTags>? Tags { get; set; }

        public string? NewsAvatar { get; set; }

        public bool IsArchived { get; set; }

        public Guid? Category { get; set; }

        public User Author { get; set; }

        public List<Division> DivisionsMentioned { get; set; }

        public List<User> UsersMentioned { get; set; }
        

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
