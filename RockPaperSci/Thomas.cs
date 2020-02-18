using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperSci
{
    class Thomas : Player
    {
        public Thomas(string playerName) : base(playerName)
        {
            playerName = "Thomas";
        }

        public override RoShamBo GenerateRoShamBo()
        {
            RoShamBo rock = RoShamBo.rock;
            return rock;
        }
    }
}
