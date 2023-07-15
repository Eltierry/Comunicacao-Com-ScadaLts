using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Publisher
    {
        public int Id { get; set; }
        public string Xid { get; set; } = null!;
        public byte[] Data { get; set; } = null!;
    }
}
