using System;

namespace RockPaperScissorsLab
{
    static class Program
    {
        static void Main(string[] args)
           
        {
            bool goOn = true;
            Console.WriteLine("We are going to play Rock, Paper, Scissors!\n");

            RPSApp game = new RPSApp();

            while (goOn)
            {
                game.Play();
                goOn = GetGoOn($"Would you like to try again {game.User.Name}? [yes] or [no]: ");
            }

          
            Console.WriteLine($"{game.User.Name}'s Wins: {game.Wins}");
            Console.WriteLine($"{game.User.Name}'s Losses: {game.Losses}\n");

            Console.WriteLine($"Se you soon {game.User.Name} :)");
        }
        public static bool GetGoOn(string question)
        {
            string response = GetInput(question);
            if (response.ToLower().Trim() == "yes")

            {
                return true;
            }
            else if (response.ToLower().Trim() == "no")

            {
                return false;
            }
            else
            {
                Console.WriteLine("That was an invalid answer, please try again.");
                Console.Write("Please respond with either [yes] or [no]\n: " ); }
            return GetGoOn(question);
        }
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string response = Console.ReadLine();
            return response;
        }

       



    }
    }


