using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Mailinglistinactive
    {
        public int MailingListId { get; set; }
        public int InactiveInterval { get; set; }

        public virtual Mailinglist MailingList { get; set; } = null!;
    }
}
