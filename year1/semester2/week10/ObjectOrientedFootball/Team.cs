using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedChallengeFootball
{
    internal class Team
    {
        public string Name { get; set; }

        public string Place { get; set; }

        public Team(string name, string place)
        {
            Name = name;
            Place = place;
        }
    }
}

