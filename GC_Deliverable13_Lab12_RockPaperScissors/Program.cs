using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Deliverable13_Lab12_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/**********************************************/");
            Console.WriteLine("/* Welcome to Clastic Papyrus Lacerator v 1.0 */");
            Console.WriteLine("/**********************************************/");
            Console.WriteLine();
            Console.WriteLine("Let's jam!");
            Console.WriteLine();

            //instantiate a validator object
            Validator validInput = new Validator();

            //instantiate opponents
            Rock opponentA = new Rock();
            RandPlayer opponentB = new RandPlayer();

            //insantiate and construct a human player
            string userChoice;
            //userChoice = validInput.GetUserInput();

            HumanPlayer human1 = new HumanPlayer();
            human1.GetUserName();
            human1.R_P_S = human1.GenerateRoshambo();
            //Rock        ai1 = new Rock("Key");
            //RandPlayer  ai2 = new RandPlayer("Peele");

            Console.WriteLine();
            Console.WriteLine($"Hi {human1.Name}!");

            //prompt user to choose opponent
            //validInput.Msg = "Would you like to play against Key or Peele? :";
            Console.WriteLine("Would you like to play against Key or Peele? :");
            string opponentChoice = Console.ReadLine();
            Console.WriteLine();

            //construct opponent
            if (opponentChoice == "k")
            {
                
                opponentA.Name = "Keenan Michael-Key";
                opponentA.R_P_S = opponentA.GenerateRoshambo();
            }
            else
            {
                
                opponentB.Name = "Jordan Peele";
                opponentB.R_P_S = opponentB.GenerateRoshambo();
            }

            //output contest results
            Console.WriteLine($"{human1.Name}: {human1.R_P_S}");
            if (opponentChoice == "k")
            {
                Console.WriteLine($"{opponentA.Name}: {opponentA.R_P_S}");
            }
            else
            {
                Console.WriteLine($"{opponentB.Name}: {opponentB.R_P_S}");
            }
        }
    }
}
