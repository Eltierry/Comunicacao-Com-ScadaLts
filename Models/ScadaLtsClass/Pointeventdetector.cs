using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Pointeventdetector
    {
        public int Id { get; set; }
        public string Xid { get; set; } = null!;
        public string? Alias { get; set; }
        public int DataPointId { get; set; }
        public int DetectorType { get; set; }
        public int AlarmLevel { get; set; }
        public double? StateLimit { get; set; }
        public int? Duration { get; set; }
        public int? DurationType { get; set; }
        public string? BinaryState { get; set; }
        public int? MultistateState { get; set; }
        public int? ChangeCount { get; set; }
        public string? AlphanumericState { get; set; }
        public double? Weight { get; set; }

        public virtual Datapoint DataPoint { get; set; } = null!;
    }
}
