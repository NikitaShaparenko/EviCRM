﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EviCRM.Core.Db.Interfaces;

namespace EviCRM.Core.Db.Entities.Core
{
    public class NewsComments : IMetaFiller
    {
        public Guid Id { get; set; }

        public Guid NewsId { get; set; }

        public User Sender { get; set; }

        public bool InReply { get; set; }

        public Guid? ReplyCommentId { get; set; }

        public string Body { get; set; }
        
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
