using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Datapointuser
    {
        public int DataPointId { get; set; }
        public int UserId { get; set; }
        public int Permission { get; set; }

        public virtual Datapoint DataPoint { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
