using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Deliverable13_Lab12_RockPaperScissors
{
    class RandPlayer : Player
    {
        public RandPlayer() : base ()
        {
            Name = "";
        }

        public override Roshambo GenerateRoshambo()
        {
            Random rand = new Random();
            return (Roshambo)(rand.Next(0, 3)); ;
        }
    }
}
