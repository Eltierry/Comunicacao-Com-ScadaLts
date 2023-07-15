using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Historyalarm
    {
        public string? ActiveTime { get; set; }
        public string? InactiveTime { get; set; }
        public string? AcknowledgeTime { get; set; }
        public sbyte? Level { get; set; }
        public string? Name { get; set; }
    }
}
