using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Eventdetectortemplate
    {
        public Eventdetectortemplate()
        {
            Templatesdetectors = new HashSet<Templatesdetector>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Templatesdetector> Templatesdetectors { get; set; }
    }
}
