using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EviCRM.Core.Db.Interfaces;
using EviCRM.Core.Db.Models;

namespace EviCRM.Core.Db.Entities.Core
{
   public class Tasks : IMetaFiller
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime? FactEndDate { get; set; }

        public List<Attachments>? Attachments { get; set; }

        public string Budget { get; set; }

        public List<User> Members { get; set; }

        public GlobalCompletionStatus Status { get; set; }

        public User ResponsibleMember { get; set; }

        public User Author { get; set; }

        public bool IsNotify{ get; set; }

        public Guid? ProjId { get; set; }

        public string tasks_personal_status { get; set; }

        public List<Division> Divisions { get; set; }

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
