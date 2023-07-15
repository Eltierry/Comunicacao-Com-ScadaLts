using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Compoundeventdetector
    {
        public int Id { get; set; }
        public string Xid { get; set; } = null!;
        public string? Name { get; set; }
        public int AlarmLevel { get; set; }
        public string ReturnToNormal { get; set; } = null!;
        public string Disabled { get; set; } = null!;
        public string ConditionText { get; set; } = null!;
    }
}
