using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Templatesdetector
    {
        public int Id { get; set; }
        public string Xid { get; set; } = null!;
        public string? Alias { get; set; }
        public int DetectorType { get; set; }
        public int AlarmLevel { get; set; }
        public float? StateLimit { get; set; }
        public int? Duration { get; set; }
        public int? DurationType { get; set; }
        public string? BinaryState { get; set; }
        public int? MultistateState { get; set; }
        public int? ChangeCount { get; set; }
        public string? AlphanumericState { get; set; }
        public float? Weight { get; set; }
        public double? Threshold { get; set; }
        public int EventDetectorTemplateId { get; set; }

        public virtual Eventdetectortemplate EventDetectorTemplate { get; set; } = null!;
    }
}
