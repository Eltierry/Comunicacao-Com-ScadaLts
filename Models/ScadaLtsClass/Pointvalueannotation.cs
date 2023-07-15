using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Pointvalueannotation
    {
        public long PointValueId { get; set; }
        public string? TextPointValueShort { get; set; }
        public string? TextPointValueLong { get; set; }
        public short? SourceType { get; set; }
        public int? SourceId { get; set; }

        public virtual Pointvalue PointValue { get; set; } = null!;
    }
}
