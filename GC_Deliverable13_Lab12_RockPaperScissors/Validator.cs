using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Deliverable13_Lab12_RockPaperScissors
{
    class Validator
    {
        //Data
        private string msg;
        private string userChoice;
        public string Msg
        {
            set { msg = value; }
        }

        //Constructors
        public Validator()
        {
            msg = "";
        }
    }
}
