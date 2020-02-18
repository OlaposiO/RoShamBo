using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperSci
{
    class UserPlayer : Player
    {
        public UserPlayer(string playerName) : base(playerName)
        {
            PlayerName = playerName;
        }

        public override RoShamBo GenerateRoShamBo()
        {
            
            Console.Write("\nRock, Paper, Scissors. Please pick your selection: ");
            RoShamBo choice = Enum.Parse<RoShamBo>(Validator(Console.ReadLine().ToLower()));

            return choice;
        }

        public string Validator(string input)
        {
            string choice = "";

            while (input != "rock" && input != "paper" && input != "scissors")
            {
                Console.WriteLine("Make a valid selection: \nRock\tPaper\tScissors");
                input = Console.ReadLine().ToLower();
            }
            choice = input;
            return choice;

        }
    }
}
