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


            //instantiate opponents
            Rock opponentA = new Rock();
            RandPlayer opponentB = new RandPlayer();

            //Instantiate a human for user input
            HumanPlayer human1 = new HumanPlayer();
            human1.GetUserName();
            Console.WriteLine();
            Console.WriteLine($"Hi {human1.Name}!");

            //construct opponent
            string opponentChoice = "";

            bool playAgain = true;
            while (playAgain)
            {
                human1.R_P_S = human1.GenerateRoshambo();

                bool validOpponent = true;
                while (validOpponent)
                {

                    //TODO: Need to validate invalid user selection
                    //if (!(human1.R_P_S == Roshambo.Rock || human1.R_P_S == Roshambo.Scissors || human1.R_P_S == Roshambo.Paper))
                    //{
                    //    Console.WriteLine("Oops! That is an invalid entry.");
                    //    return;
                    //}

                    Console.Write("Would you like to play against Key or Peele? (k or p): ");
                    opponentChoice = Console.ReadLine();
                    Console.WriteLine();

                    if (opponentChoice.ToLower() == "k")
                    {

                        opponentA.Name = "Keegan-Michael Key";
                        opponentA.R_P_S = opponentA.GenerateRoshambo();
                        validOpponent = false;
                    }
                    else if (opponentChoice.ToLower() == "p")
                    {
                        opponentB.Name = "Jordan Peele";
                        opponentB.R_P_S = opponentB.GenerateRoshambo();
                        validOpponent = false;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("I'm sorry, but that was not a valid option. Please try again");
                        Console.WriteLine();
                    }
                }

                //output contest results
                Console.WriteLine($"{human1.Name}: {human1.R_P_S}");
                if (opponentChoice == "k")
                {
                    Console.WriteLine($"{opponentA.Name}: {opponentA.R_P_S}");
                    human1.FindWinner(opponentA);
                }
                else
                {
                    Console.WriteLine($"{opponentB.Name}: {opponentB.R_P_S}");
                    human1.FindWinner(opponentB);
                }
                Console.WriteLine();

                while (true)
                {
                    Console.Write("Do you want to play again (y/n): ");
                    string playAgainInput = Console.ReadLine().ToLower();
                    if (playAgainInput == "n")
                    {
                        playAgain = false;
                        break;
                    }
                    else if (playAgainInput == "y")
                    {
                        playAgain = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry. I didn't understand that.");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Thanks for playing! Come back soon.");
        }
    }
}
