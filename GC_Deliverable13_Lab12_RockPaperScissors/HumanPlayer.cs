using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Deliverable13_Lab12_RockPaperScissors
{
    class HumanPlayer : Player
    {
        public HumanPlayer() : base ()
        {
            Name = "";
        }

        public override Roshambo GenerateRoshambo()
        {
            Console.Write("Select rock (r), paper (p), or scissors (s): ");
            Roshambo rosh = (Roshambo)0;
            string str = Console.ReadLine();

            if (str != "r")
            {
                rosh = (str == "p") ? Roshambo.Paper : Roshambo.Scissors;
            }

            return rosh;
        }

        public void GetUserName ()
        {
            Console.Write("Hi there! Can I have your name please? : ");
            Name = Console.ReadLine();
        }
    }
}
