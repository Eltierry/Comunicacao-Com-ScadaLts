using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Mailinglistmember
    {
        public int MailingListId { get; set; }
        public int TypeId { get; set; }
        public int? UserId { get; set; }
        public string? Address { get; set; }

        public virtual Mailinglist MailingList { get; set; } = null!;
    }
}
