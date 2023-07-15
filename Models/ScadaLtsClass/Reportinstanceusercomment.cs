using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Reportinstanceusercomment
    {
        public int ReportInstanceId { get; set; }
        public string? Username { get; set; }
        public int CommentType { get; set; }
        public int TypeKey { get; set; }
        public long Ts { get; set; }
        public string CommentText { get; set; } = null!;

        public virtual Reportinstance ReportInstance { get; set; } = null!;
    }
}
