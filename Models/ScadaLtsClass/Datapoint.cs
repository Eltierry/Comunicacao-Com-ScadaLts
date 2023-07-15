using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Datapoint
    {
        public Datapoint()
        {
            Plcalarms = new HashSet<Plcalarm>();
            Pointeventdetectors = new HashSet<Pointeventdetector>();
            Pointvalues = new HashSet<Pointvalue>();
        }

        public int Id { get; set; }
        public string Xid { get; set; } = null!;
        public int DataSourceId { get; set; }
        public byte[] Data { get; set; } = null!;
        /// <summary>
        /// copy point name from data
        /// </summary>
        public string? PointName { get; set; }
        /// <summary>
        /// 1 - FAULT, 2 - ALARM
        /// </summary>
        public sbyte? PlcAlarmLevel { get; set; }

        public virtual Datasource DataSource { get; set; } = null!;
        public virtual ICollection<Plcalarm> Plcalarms { get; set; }
        public virtual ICollection<Pointeventdetector> Pointeventdetectors { get; set; }
        public virtual ICollection<Pointvalue> Pointvalues { get; set; }
    }
}
