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
        public List<History> Rounds = new List<History>(); 
        public int Round { get; set; }
        public string Result { get; set; }
        public string Team { get; set; }
        public string ByeIn { get; set; }
        public History() // Default values
        {
            _byeIn = "None";
            _team = "None";
            _result = "None";
            _round = -1; 
        }
        public History(string team, string result , int round , string byeIn)
        {
            Round = round;
            Result = result;
            Team = team;
            ByeIn = byeIn;
        }                    
    }
}
