using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Reportinstancedatum
    {
        public long PointValueId { get; set; }
        public int ReportInstancePointId { get; set; }
        public double? PointValue { get; set; }
        public long Ts { get; set; }

        public virtual Reportinstancepoint ReportInstancePoint { get; set; } = null!;
        public virtual Reportinstancedataannotation Reportinstancedataannotation { get; set; } = null!;
    }
}
