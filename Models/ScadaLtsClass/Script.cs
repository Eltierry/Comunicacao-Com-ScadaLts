using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Script
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Xid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Script1 { get; set; } = null!;
        public byte[] Data { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
