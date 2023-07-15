using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Mailinglist
    {
        public int Id { get; set; }
        public string Xid { get; set; } = null!;
        public string Name { get; set; } = null!;
        /// <summary>
        /// cron pattern
        /// </summary>
        public string? CronPattern { get; set; }
        /// <summary>
        /// Collect inactive emails and send when activated
        /// </summary>
        public byte[]? CollectInactiveEmails { get; set; }
        /// <summary>
        /// Daily limit sent emails
        /// </summary>
        public byte[]? DailyLimitSentEmails { get; set; }
        /// <summary>
        /// Daily limit sent emails number
        /// </summary>
        public int? DailyLimitSentEmailsNumber { get; set; }
    }
}
