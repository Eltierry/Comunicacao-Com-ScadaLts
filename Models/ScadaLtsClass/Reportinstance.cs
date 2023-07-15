using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Reportinstance
    {
        public Reportinstance()
        {
            Reportinstanceevents = new HashSet<Reportinstanceevent>();
            Reportinstancepoints = new HashSet<Reportinstancepoint>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; } = null!;
        public int IncludeEvents { get; set; }
        public string IncludeUserComments { get; set; } = null!;
        public long ReportStartTime { get; set; }
        public long ReportEndTime { get; set; }
        public long? RunStartTime { get; set; }
        public long? RunEndTime { get; set; }
        public int? RecordCount { get; set; }
        public string? PreventPurge { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Reportinstanceevent> Reportinstanceevents { get; set; }
        public virtual ICollection<Reportinstancepoint> Reportinstancepoints { get; set; }
    }
}
