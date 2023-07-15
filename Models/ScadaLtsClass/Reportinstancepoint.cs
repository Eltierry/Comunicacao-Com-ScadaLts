using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Reportinstancepoint
    {
        public Reportinstancepoint()
        {
            Reportinstancedata = new HashSet<Reportinstancedatum>();
        }

        public int Id { get; set; }
        public int ReportInstanceId { get; set; }
        public string DataSourceName { get; set; } = null!;
        public string PointName { get; set; } = null!;
        public int DataType { get; set; }
        public string? StartValue { get; set; }
        public byte[]? TextRenderer { get; set; }
        public string? Colour { get; set; }
        public string? ConsolidatedChart { get; set; }

        public virtual Reportinstance ReportInstance { get; set; } = null!;
        public virtual ICollection<Reportinstancedatum> Reportinstancedata { get; set; }
    }
}
