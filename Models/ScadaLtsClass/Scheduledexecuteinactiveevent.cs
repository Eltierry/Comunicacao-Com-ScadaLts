using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Scheduledexecuteinactiveevent
    {
        public int MailingListId { get; set; }
        public int SourceEventId { get; set; }
        public int EventHandlerId { get; set; }

        public virtual Eventhandler EventHandler { get; set; } = null!;
        public virtual Mailinglist MailingList { get; set; } = null!;
        public virtual Event SourceEvent { get; set; } = null!;
    }
}
