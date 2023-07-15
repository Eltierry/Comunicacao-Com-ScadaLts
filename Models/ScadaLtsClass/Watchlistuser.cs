using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Watchlistuser
    {
        public int WatchListId { get; set; }
        public int UserId { get; set; }
        public int AccessType { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Watchlist WatchList { get; set; } = null!;
    }
}
