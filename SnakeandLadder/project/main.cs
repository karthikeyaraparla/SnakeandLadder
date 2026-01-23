using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SnakeandLadder
{
    class SnakeGame
    {
        static void Main()
        {
            Random random = new Random();

            Console.WriteLine("Welcome to Snake and Ladder Game");

            int START_POSITION = 0;
            int player_position = START_POSITION;
            int dice_count = 0;

            Console.WriteLine($"Game started. Player is at position {player_position}");

            while (player_position < 100)
            {
                int dice = random.Next(1, 7);
                dice_count++;

                Console.WriteLine($"Dice rolled: {dice}");

                int options = random.Next(0, 3);

                if (options == 0)
                {
                    Console.WriteLine("No Play");
                }
                else if (options == 1)
                {
                    Console.WriteLine("Ladder");
                    int new_position = player_position + dice;

                    if (new_position <= 100)
                    {
                        player_position = new_position;
                    }
                    else
                    {
                        Console.WriteLine("Move exceeds 100, staying at same position");
                    }
                }
                else
                {
                    Console.WriteLine("Snake");
                    player_position -= dice;

                    if (player_position < 0)
                        player_position = 0;
                }

                Console.WriteLine($"Player position: {player_position}");
            }

            
            Console.WriteLine($"Player reached position {player_position}");
            Console.WriteLine($"Total dice rolls: {dice_count}");
            Console.ReadLine();
        }
    }
}
