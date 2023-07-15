using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Watchlist
    {
        public Watchlist()
        {
            Watchlistusers = new HashSet<Watchlistuser>();
        }

        public int Id { get; set; }
        public string Xid { get; set; } = null!;
        public int UserId { get; set; }
        public string? Name { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Watchlistuser> Watchlistusers { get; set; }
    }
}
