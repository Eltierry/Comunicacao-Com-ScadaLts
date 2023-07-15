using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Mangoviewuser
    {
        public int MangoViewId { get; set; }
        public int UserId { get; set; }
        public int AccessType { get; set; }

        public virtual Mangoview MangoView { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
