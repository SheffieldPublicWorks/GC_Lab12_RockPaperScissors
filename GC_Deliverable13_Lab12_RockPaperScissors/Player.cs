using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Deliverable13_Lab12_RockPaperScissors
{
    abstract class Player
    {
        //Fields and properties
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Roshambo r_p_s;
        public Roshambo R_P_S
        {
            get { return r_p_s; }
            set { r_p_s = value; }
        }

        public Player ()
        {
            name = "";
            r_p_s = 0;
        }

        abstract public Roshambo GenerateRoshambo ();
    }
}
