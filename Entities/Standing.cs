using System;

namespace Entities
{
    public class Standing
    {
        public int IdStanding { get; set; }
        public int Rank { get; set; }
        public int IdTeam { get; set; }
        public string Team { get; set; }
        public string TeamBadge { get; set; }
        public int IdLeague { get; set; }
        public string League { get; set; }
        public string Season { get; set; }
        public string Form { get; set; }
        public string Description { get; set; }
        public int Played { get; set; }
        public int Win { get; set; }
        public int Loss { get; set; }
        public int Draw { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalDifference { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
