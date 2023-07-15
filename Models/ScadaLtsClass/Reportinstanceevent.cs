using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Reportinstanceevent
    {
        public int EventId { get; set; }
        public int ReportInstanceId { get; set; }
        public int TypeId { get; set; }
        public int TypeRef1 { get; set; }
        public int TypeRef2 { get; set; }
        public long ActiveTs { get; set; }
        public string RtnApplicable { get; set; } = null!;
        public long? RtnTs { get; set; }
        public int? RtnCause { get; set; }
        public int AlarmLevel { get; set; }
        public string? Message { get; set; }
        public long? AckTs { get; set; }
        public string? AckUsername { get; set; }
        public int? AlternateAckSource { get; set; }

        public virtual Reportinstance ReportInstance { get; set; } = null!;
    }
}
