using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperSci
{
    class Steve : Player
    {
        public Steve(string playerName) : base(playerName)
        {
            playerName = "Steve";
        }

        public override RoShamBo GenerateRoShamBo()
        {
            Random randomRoShamBo = new Random();
            return (RoShamBo)randomRoShamBo.Next(0, 3);
        }
    }
}
