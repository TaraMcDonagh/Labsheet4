using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Team
    {
        public string TeamName { get; private set; }
        public int TeamWins { get; private set; }
        public int TeamLosses { get; private set; }
        public int TeamDraw { get; private set; }
        public int TeamPlayed { get; private set; }
        private int _points;
        public int Points
        {
            get
            {
                _points = (TeamWins * 3) + (TeamDraw * 1);
                return _points;
            }    
        }

    }
}
