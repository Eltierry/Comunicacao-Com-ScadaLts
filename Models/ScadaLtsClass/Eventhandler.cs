using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Eventhandler
    {
        public int Id { get; set; }
        public string Xid { get; set; } = null!;
        public string? Alias { get; set; }
        public int EventTypeId { get; set; }
        public int EventTypeRef1 { get; set; }
        public int EventTypeRef2 { get; set; }
        public byte[] Data { get; set; } = null!;
    }
}
