using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traduttore_Json {
    public class MacthLive { 
        public string Id { get; set; }
        public bool isLive { get; set; }
        public bool IsStarted { get; set; }
        public bool isFinished { get; set; }
        public double Minute { get; set; }
        public string TeamAwayName { get; set; }
        public string TeamHomeName { get; set; }
        public string Competition { get; set; }
        public string StartTime { get; set; }
        public int? ScoreHome { get; set; }
        public int? ScoreAway { get; set; }



    }
}
