using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperSci
{
    class StartGame
    {
        public void Start()
        {

            string name = GetInout("What is your name? ");
            UserPlayer player = new UserPlayer(name);

            do
            {
                string userchoice = GetInout($"Welcome {player.PlayerName} would you like to play against Steve or Thomas?").ToLower();
                while (userchoice != "thomas" && userchoice != "steve")
                {
                    Console.WriteLine("Please pick between Steve and Thomas");
                    userchoice = Console.ReadLine().ToLower();
                }
                if (userchoice == "steve" )
                {
                    Rock(ref name);
                }
                else if (userchoice == "thomas")
                {

                    RandomPick(ref name);
                }


            } while (Continue());
            Console.WriteLine("Farewell");
        }
        public void RandomPick(ref string name)
        {
            UserPlayer player = new UserPlayer(name);

            string input = player.GenerateRoShamBo().ToString();
            Steve comp = new Steve("thomas");

            string opponent = comp.GenerateRoShamBo().ToString();

            Console.WriteLine($"\n{player.PlayerName} chose {input}." +
            $"\n{comp.PlayerName} chose {opponent}");

            if ((input == "rock" && opponent == "scissors") || (input == "scissors" && opponent == "paper") || (input == "paper" && opponent == "rock"))
            {
                Console.WriteLine($"\n{player.PlayerName} wins!");
            }
            else if ((opponent == "rock" && input == "scissors") || (opponent == "scissors" && input == "paper") || (opponent == "paper" && input == "rock"))
            {
                Console.WriteLine($"\n{comp.PlayerName} wins!");
            }
            else if (input == opponent)
            {
                Console.WriteLine("\nThats a tie... hmm");
            }
        }
        public void Rock(ref string name)
        {
            UserPlayer player = new UserPlayer(name);

            string input = player.GenerateRoShamBo().ToString();
            Thomas comp = new Thomas("steve");

            string opponent = comp.GenerateRoShamBo().ToString();

            Console.WriteLine($"\n{player.PlayerName} chose {input}." +
            $"\n{comp.PlayerName} chose {opponent}");

            if (input == "paper")
            {
                Console.WriteLine($"\n{player.PlayerName} wins");
            }
            else if (input == "scissors")
            {
                Console.WriteLine($"\n{comp.PlayerName} wins!");
            }
            else if (input == "rock")
            {
                Console.WriteLine("\nThat's a tie... hmm");
            }
        }

        public string GetInout(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine().ToLower();
        }

        static bool Continue()
        {
            char c;

            do
            {
                Console.WriteLine("\nAnother round? y/n");
                c = Console.ReadKey().KeyChar;
                if (c == 'n' || c == 'N')
                {
                    
                    Console.Clear();
                    return false;
                }
            } while (c != 'y' && c != 'Y');

            
            Console.Clear();
            return true;

        }
    }
    }

