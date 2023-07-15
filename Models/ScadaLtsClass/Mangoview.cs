using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Mangoview
    {
        public Mangoview()
        {
            Mangoviewusers = new HashSet<Mangoviewuser>();
        }

        public int Id { get; set; }
        public string Xid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Background { get; set; }
        public int UserId { get; set; }
        public int AnonymousAccess { get; set; }
        public byte[] Data { get; set; } = null!;
        public int? Width { get; set; }
        public int? Height { get; set; }
        public DateTime? ModificationTime { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Mangoviewuser> Mangoviewusers { get; set; }
    }
}
