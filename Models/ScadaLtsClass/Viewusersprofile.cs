using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Viewusersprofile
    {
        public int ViewId { get; set; }
        public int UserProfileId { get; set; }
        public int Permission { get; set; }

        public virtual Usersprofile UserProfile { get; set; } = null!;
        public virtual Mangoview View { get; set; } = null!;
    }
}
