using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Datasourceusersprofile
    {
        public int DataSourceId { get; set; }
        public int UserProfileId { get; set; }

        public virtual Datasource DataSource { get; set; } = null!;
        public virtual Usersprofile UserProfile { get; set; } = null!;
    }
}
