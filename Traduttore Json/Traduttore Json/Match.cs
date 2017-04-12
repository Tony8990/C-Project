using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traduttore_Json {
    public class Match {
        
        public string AwayTeamName { get; set; }
        public string HomeTeamName { get; set; }
        public string CompetitionName { get; set; }
        public Int32 IdMatch { get; set; }
        public DateTime MatchDate { get; set; }
        public int? ScoreAway { get; set; }
        public int? ScoreHome { get; set; }
        public string WinTeamName { get; set; }


    }
}
