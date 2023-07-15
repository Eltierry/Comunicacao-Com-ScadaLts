using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Pointvalue
    {
        public long Id { get; set; }
        public int DataPointId { get; set; }
        public int DataType { get; set; }
        public double? PointValue1 { get; set; }
        public long Ts { get; set; }

        public virtual Datapoint DataPoint { get; set; } = null!;
    }
}
