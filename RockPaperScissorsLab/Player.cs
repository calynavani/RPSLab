using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLab
{
   
    abstract class Player
    {
        public string Name { get; set; }
        public RPSEnum RPSValue{ get; set;}

        public abstract RPSEnum GenerateRPS();

      

       

        
        
    }

}
