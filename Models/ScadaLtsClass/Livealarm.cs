using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Livealarm
    {
        public uint Id { get; set; }
        public string? ActivationTime { get; set; }
        public string? InactivationTime { get; set; }
        public string? Level { get; set; }
        public string? Name { get; set; }
        public int DataPointId { get; set; }
    }
}
