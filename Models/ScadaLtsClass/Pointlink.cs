using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Pointlink
    {
        public int Id { get; set; }
        public string Xid { get; set; } = null!;
        public int SourcePointId { get; set; }
        public int TargetPointId { get; set; }
        public string? Script { get; set; }
        public int EventType { get; set; }
        public string Disabled { get; set; } = null!;
    }
}
