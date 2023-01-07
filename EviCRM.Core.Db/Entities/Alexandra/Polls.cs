using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EviCRM.Core.Db.Interfaces;

namespace EviCRM.Core.Db.Entities.Alexandra
{
    public class Polls : IMetaFiller
    {
        public Guid Id { get; set; }

        public string Question { get; set; }

        public string? Explanations { get; set; }

        public bool IsMultipleAnswers { get; set; }

        public bool IsAnon { get; set; }

        public bool IsActive { get; set; }

        public string? MultipleAnswers { get; set; }

        public string? Options { get; set; }

        public string Type { get; set; }

        public string CorrectOptionId { get; set; }

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
