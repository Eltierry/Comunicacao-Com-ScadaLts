using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Usercomment
    {
        public int? UserId { get; set; }
        public int CommentType { get; set; }
        public int TypeKey { get; set; }
        public long Ts { get; set; }
        public string CommentText { get; set; } = null!;

        public virtual User? User { get; set; }
    }
}
