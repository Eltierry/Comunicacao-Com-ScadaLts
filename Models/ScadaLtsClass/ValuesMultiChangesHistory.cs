using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class ValuesMultiChangesHistory
    {
        public int Id { get; set; }
        public int? MultiChangesHistoryId { get; set; }
        public long? ValueId { get; set; }
        public string Value { get; set; } = null!;
        public int? DataPointId { get; set; }
        public long? Ts { get; set; }
    }
}
