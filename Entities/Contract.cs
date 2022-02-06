namespace Entities
{
    public class Contract
    {
        public int Id { get; set; }
        public int IdPlayer { get; set; }
        public int IdTeam { get; set; }
        public string Sport { get; set; }
        public string Player { get; set; }
        public string Team { get; set; }
        public string TeamBadge { get; set; }
        public string YearStart { get; set; }
        public string YearEnd { get; set; }
        public string Wage { get; set; }
    }
}
