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

        public void FindWinner (Player p)
        {
            if (R_P_S == p.R_P_S)
            {
                Console.WriteLine("Draw!");
            }
            else if (R_P_S == Roshambo.Paper && p.R_P_S == Roshambo.Rock)
            {
                Console.WriteLine($"{Name} wins!");
            }
            else if (R_P_S == Roshambo.Rock && p.R_P_S == Roshambo.Scissors)
            {
                Console.WriteLine($"{Name} wins!");
            }
            else if (R_P_S == Roshambo.Scissors && p.R_P_S == Roshambo.Paper)
            {
                Console.WriteLine($"{Name} wins!");
            }
            else
            {
                Console.WriteLine($"{p.Name} wins!");
            }
        }

        public override Roshambo GenerateRoshambo()
        {
            Console.Write("Select rock (r), paper (p), or scissors (s): ");
            Roshambo rosh = (Roshambo)0;
            string str = Console.ReadLine();

            if (str == "r")
            {
                rosh = Roshambo.Rock;
            }
            else if (str == "p")
            {
                rosh = Roshambo.Paper;
            }
            else if (str == "s")
            {
                rosh = Roshambo.Scissors;
            }
            else
            {
                Console.WriteLine("Please choose rock, paper, or scissors.");
                return GenerateRoshambo();
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
