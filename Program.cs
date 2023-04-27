using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random ran = new Random();

                Console.Write("Rock, Paper, Scissors?: ");
                string player = Console.ReadLine();
                player = player.ToUpper();

                string[] computer = { "ROCK", "PAPER", "SCISSORS" };
                string comchose = (computer[ran.Next(3)]);

                Console.WriteLine("\nPLAYER: " + player + "\nCOMPUTER: " + comchose);

                switch (player)
                {
                    case "ROCK":
                        if(comchose == "ROCK")
                        {
                            Console.WriteLine("\nIt's a draw!");
                        }
                        else if(comchose == "PAPER")
                        {
                            Console.WriteLine("\nYou lose!");
                        }
                        else if (comchose == "SCISSORS")
                        {
                            Console.WriteLine("\nYou win!");
                        }
                        break;
                    case "PAPER":
                        if (comchose == "ROCK")
                        {
                            Console.WriteLine("\nYou win!");
                        }
                        else if (comchose == "PAPER")
                        {
                            Console.WriteLine("\nIt's a draw!");
                        }
                        else if (comchose == "SCISSORS")
                        {
                            Console.WriteLine("\nYou lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (comchose == "ROCK")
                        {
                            Console.WriteLine("\nYou lose!");
                        }
                        else if (comchose == "PAPER")
                        {
                            Console.WriteLine("\nYou win!");
                        }
                        else if (comchose == "SCISSORS")
                        {
                            Console.WriteLine("\nIt's a draw!");
                        }
                        break;
                }

                Console.WriteLine("Try again? Y/N");
                string select = Console.ReadLine();

                if(select == "Y" || select == "y")
                {
                    Console.WriteLine("");
                    continue;
                }
                else if(select == "N" || select == "n")
                {
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
                else
                {
                    Console.WriteLine("Input contains '" + select + "' is not on the list!");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
