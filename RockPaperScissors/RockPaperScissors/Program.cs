using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool PlayAgain = true;
            String player;
            String computer;
       
            

            while (PlayAgain) 
            {
                player = "";
                computer = "";
                while (player != "ROCK" && player!="PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK, PAPER, or SCISSORS");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                    

                    
                }
                // ROCK = 1     PAPER = 2       SCISSORS = 3
                switch (rand.Next(1,4)) 
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player) 
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else 
                        {
                            Console.WriteLine("You Win!");
                        }
                        break;

                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Draw");
                        }
                        else
                        {
                            Console.WriteLine("You Lose!");
                        }
                        break;

                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Win!"); 
                        }
                        else
                        {
                            Console.WriteLine("Draw");
                        }
                        break;
                }

                Console.WriteLine("Play again? [Y/N]");
                String ans = "";
                while (ans != "Y" && ans != "N")
                {
                    ans = Console.ReadLine().ToUpper();
                }

                if (ans == "N")
                {
                    PlayAgain = false;
                }

            }
            Console.WriteLine("Goodbye!");

            Console.ReadKey();
        }
    }
}
