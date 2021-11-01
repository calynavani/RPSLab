using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLab
{
    class Rocky : Player
    {
        public Rocky()
        {
            Name = "Rocky";
        }
        public override RPSEnum GenerateRPS()
        {
            return RPSEnum.Rock;
        }

        //internal bool GetRPS()
        //{
        //    return true;
        //}
    }

}
