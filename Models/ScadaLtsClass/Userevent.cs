using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Userevent
    {
        public int EventId { get; set; }
        public int UserId { get; set; }
        public string Silenced { get; set; } = null!;

        public virtual Event Event { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
