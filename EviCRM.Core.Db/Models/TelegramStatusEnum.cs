using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EviCRM.Core.Db.Models
{
    public enum TelegramSyncStatusEnum
    {
        NotAssociated,
        AssociatedAdmin,
        AssociatedUser,
        Banned,
        Ignore,
        PushOnly,
    }
}
