using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Watchlistpoint
    {
        public int WatchListId { get; set; }
        public int DataPointId { get; set; }
        public int SortOrder { get; set; }

        public virtual Datapoint DataPoint { get; set; } = null!;
        public virtual Watchlist WatchList { get; set; } = null!;
    }
}
