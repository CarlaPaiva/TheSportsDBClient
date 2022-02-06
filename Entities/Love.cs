using System;

namespace Entities
{
    public class Love
    {
        public int IdEdit { get; set; }
        public string Username { get; set; }
        public string EditType { get; set; }
        public string Reason { get; set; }
        public DateTime Date { get; set; }
        public int? IdTeam { get; set; }
        public int? IdPlayer { get; set; }
        public int? IdLeague { get; set; }
        public int? IdEvent { get; set; }
        public string Team { get; set; }
        public string Player { get; set; }
        public string League { get; set; }
        public string Event { get; set; }
        public string EventPoster { get; set; }
        public string PlayerThumb { get; set; }
        public string TeamBadge { get; set; }
    }
}
