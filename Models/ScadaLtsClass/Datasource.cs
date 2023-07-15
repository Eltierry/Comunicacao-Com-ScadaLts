using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Datasource
    {
        public Datasource()
        {
            Datapoints = new HashSet<Datapoint>();
            Maintenanceevents = new HashSet<Maintenanceevent>();
        }

        public int Id { get; set; }
        public string Xid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int DataSourceType { get; set; }
        public byte[] Data { get; set; } = null!;

        public virtual ICollection<Datapoint> Datapoints { get; set; }
        public virtual ICollection<Maintenanceevent> Maintenanceevents { get; set; }
    }
}
