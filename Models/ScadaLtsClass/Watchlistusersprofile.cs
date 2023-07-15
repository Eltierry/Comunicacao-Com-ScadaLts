using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Watchlistusersprofile
    {
        public int WatchlistId { get; set; }
        public int UserProfileId { get; set; }
        public int Permission { get; set; }

        public virtual Usersprofile UserProfile { get; set; } = null!;
        public virtual Watchlist Watchlist { get; set; } = null!;
    }
}
