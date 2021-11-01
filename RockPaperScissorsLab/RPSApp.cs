using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLab
{
    class RPSApp
    {
        public int Wins { get; set; }

        public int Losses { get; set; }
        
        public UserPlayer User { get; set; } = new UserPlayer();
        public Player Opponent { get; set; }

        public RPSApp()
        {
            Console.WriteLine();
            Console.Write($"Welcome {User.Name} :) I hope you're ready!");

            Console.WriteLine();
           
            Console.Write("Who would you like to beat?\n[1] for Ms. Randa, [2] for Mr. Rocky. : ");
            Console.WriteLine();
            Opponent = new Rocky(); new Randa();
        }

        public void Play()
        {
           User.GenerateRPS();
            Console.WriteLine(User.GenerateRPS());

           Opponent.GenerateRPS();
            Console.WriteLine( Opponent.GenerateRPS());




            
        }

    }
}
