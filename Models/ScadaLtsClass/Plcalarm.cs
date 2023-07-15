using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Plcalarm
    {
        public uint Id { get; set; }
        public int DataPointId { get; set; }
        public string? DataPointXid { get; set; }
        public string? DataPointType { get; set; }
        public string? DataPointName { get; set; }
        public long? ActiveTime { get; set; }
        public long? InactiveTime { get; set; }
        public long? AcknowledgeTime { get; set; }
        public sbyte? Level { get; set; }

        public virtual Datapoint DataPoint { get; set; } = null!;
    }
}
