using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class Scheduledevent
    {
        public int Id { get; set; }
        public string Xid { get; set; } = null!;
        public string? Alias { get; set; }
        public int AlarmLevel { get; set; }
        public int ScheduleType { get; set; }
        public string ReturnToNormal { get; set; } = null!;
        public string Disabled { get; set; } = null!;
        public int? ActiveYear { get; set; }
        public int? ActiveMonth { get; set; }
        public int? ActiveDay { get; set; }
        public int? ActiveHour { get; set; }
        public int? ActiveMinute { get; set; }
        public int? ActiveSecond { get; set; }
        public string? ActiveCron { get; set; }
        public int? InactiveYear { get; set; }
        public int? InactiveMonth { get; set; }
        public int? InactiveDay { get; set; }
        public int? InactiveHour { get; set; }
        public int? InactiveMinute { get; set; }
        public int? InactiveSecond { get; set; }
        public string? InactiveCron { get; set; }
    }
}
