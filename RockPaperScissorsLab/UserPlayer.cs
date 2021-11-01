using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLab
{
    class UserPlayer : Player
    {

        public UserPlayer()
        {
            Console.Write("What is your name? ");
            Name = Console.ReadLine();

        }

        //internal RPSEnum GetRPS()
        //{
        //    return GenerateRPS();
        //}

        public override RPSEnum GenerateRPS()
        {
            Console.WriteLine();
            Console.Write($"Now {Name}, please select Rock, Paper, or Scissors: ");
            string userSelection = Console.ReadLine().ToLower();
            Console.WriteLine();

            switch (userSelection)
            {
                case "rock":
                    return RPSEnum.Rock;

                case "paper":
                    return RPSEnum.Paper;
                case "scissors":
                    return RPSEnum.Scissors;
                default:
                    Console.WriteLine("That was an invalid answer.");
                    Console.WriteLine("Please try again");
                    return GenerateRPS();

            }
        }
    }
}
