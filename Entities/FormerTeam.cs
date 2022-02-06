namespace Entities
{
    public class FormerTeam
    {
        public int Id { get; set; }
        public int IdPlayer { get; set; }
        public int IdFormerTeam { get; set; }
        public string Sport { get; set; }
        public string Player { get; set; }
        public string FormerTeamName { get; set; }
        public string MoveType { get; set; }
        public string TeamBadge { get; set; }
        public string Joined { get; set; }
        public string Departed { get; set; }
    }
}
