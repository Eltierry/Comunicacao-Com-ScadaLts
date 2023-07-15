using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Usersusersprofile
    {
        public int UserProfileId { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Usersprofile UserProfile { get; set; } = null!;
    }
}
