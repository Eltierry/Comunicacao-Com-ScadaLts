using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Datapointusersprofile
    {
        public int DataPointId { get; set; }
        public int UserProfileId { get; set; }
        public int Permission { get; set; }

        public virtual Datapoint DataPoint { get; set; } = null!;
        public virtual Usersprofile UserProfile { get; set; } = null!;
    }
}
