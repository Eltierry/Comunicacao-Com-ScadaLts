using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class MultiChangesHistory
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? Username { get; set; }
        public string ViewAndComponentIdentification { get; set; } = null!;
        public string InterpretedState { get; set; } = null!;
        public long? Ts { get; set; }
    }
}
