using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Reportinstancedataannotation
    {
        public long PointValueId { get; set; }
        public int ReportInstancePointId { get; set; }
        public string? TextPointValueShort { get; set; }
        public string? TextPointValueLong { get; set; }
        public string? SourceValue { get; set; }

        public virtual Reportinstancedatum Reportinstancedatum { get; set; } = null!;
    }
}
