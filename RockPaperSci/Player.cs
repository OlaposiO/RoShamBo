using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperSci
{
    abstract class Player
    {
        private string playerName;

        public Player(string playerName)
        {
            this.PlayerName = playerName;
        }

        public string PlayerName { get => playerName; set => playerName = value; }

        public abstract RoShamBo GenerateRoShamBo();
    }
}
