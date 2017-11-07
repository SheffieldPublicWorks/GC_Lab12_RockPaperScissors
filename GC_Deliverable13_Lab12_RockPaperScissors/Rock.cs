using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Deliverable13_Lab12_RockPaperScissors
{
    class Rock : Player
    {
        public Rock () : base ()
        {
            Name = "";
        }

        public override Roshambo GenerateRoshambo()
        {
            return 0;
        }
    }
}
