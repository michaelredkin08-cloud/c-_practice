using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedChallengeFootball
{
    internal class History
    {
        public List<History> rounds = new List<History>();

        public Team TeamPlayed { get; set; }
        public string Result { get; set; }
        public int Round { get; set; }
        public string ByeIn { get; set; }
        public History(Team teamPlayed, string result, int round, string byeIn)
        {
            TeamPlayed = teamPlayed;
            Result = result;
            Round = round;
            ByeIn = byeIn;
        }
    }
}
