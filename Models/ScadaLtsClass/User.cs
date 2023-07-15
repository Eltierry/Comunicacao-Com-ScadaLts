using System;
using System.Collections.Generic;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class User
    {
        public User()
        {
            Events = new HashSet<Event>();
            Mangoviews = new HashSet<Mangoview>();
            Mangoviewusers = new HashSet<Mangoviewuser>();
            Reportinstances = new HashSet<Reportinstance>();
            Reports = new HashSet<Report>();
            Scripts = new HashSet<Script>();
            Userevents = new HashSet<Userevent>();
            Watchlists = new HashSet<Watchlist>();
            Watchlistusers = new HashSet<Watchlistuser>();
        }

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string Admin { get; set; } = null!;
        public string Disabled { get; set; } = null!;
        public long? LastLogin { get; set; }
        public int? SelectedWatchList { get; set; }
        public string? HomeUrl { get; set; }
        public int ReceiveAlarmEmails { get; set; }
        public string ReceiveOwnAuditEvents { get; set; } = null!;
        public bool? HideMenu { get; set; }
        public string? Theme { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Mangoview> Mangoviews { get; set; }
        public virtual ICollection<Mangoviewuser> Mangoviewusers { get; set; }
        public virtual ICollection<Reportinstance> Reportinstances { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<Script> Scripts { get; set; }
        public virtual ICollection<Userevent> Userevents { get; set; }
        public virtual ICollection<Watchlist> Watchlists { get; set; }
        public virtual ICollection<Watchlistuser> Watchlistusers { get; set; }
    }
}
