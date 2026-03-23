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

        public string Round { get; set; }
        public History(Team team, string result , string round , string byeIn)
        {
            Round = round;
        }
    }
}
