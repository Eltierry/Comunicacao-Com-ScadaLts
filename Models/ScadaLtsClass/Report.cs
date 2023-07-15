using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Report
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] Data { get; set; } = null!;
        public string? Xid { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
