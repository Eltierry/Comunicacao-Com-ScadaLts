using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Pointhierarchy
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string? Name { get; set; }
        public string? Xid { get; set; }
    }
}
