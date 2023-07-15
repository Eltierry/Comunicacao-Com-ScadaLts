using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Datasourceuser
    {
        public int DataSourceId { get; set; }
        public int UserId { get; set; }

        public virtual Datasource DataSource { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
