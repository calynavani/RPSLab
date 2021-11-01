using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLab
{
    class Randa : Player
    {

        public Randa()
        {
            Name = "Randa";
        }
        public override RPSEnum GenerateRPS()
        {

            Random randomRPS = new Random();

            int ran = 0;
            ran = randomRPS.Next(0, 3);

            RPSEnum placeHolder;

            switch (ran)
            {
                case 0:
                    placeHolder = RPSEnum.Rock;
                    break;
                case 1:
                    placeHolder = RPSEnum.Paper;
                    break;
                case 2:
                    placeHolder = RPSEnum.Scissors;
                    break;
                default:
                    return GenerateRPS();

            }

            return placeHolder;

        }
    }
}
