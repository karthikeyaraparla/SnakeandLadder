using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    class Random
    {
        static Random random = new Random();

        Console.WriteLine("Welcome to Snake and Ladder Game");

        int START_POSITION = 0;
        int player_position = START_POSITION;

        Console.WriteLine("Game started. Player is at position {player_position}.");

        dice = random.Next(1, 7);
        Console.WriteLine("Dice rolled: {dice}");

        options = random.Next(0, 3);

        if (options == 0){
            Console.WriteLine("No play");
        }
        else if (options == 1){
            Console.WriteLine("Ladder");
            player_position = player_position + dice;
        }
        else if (options == 2){
            Console.WriteLine("Snake");
            player_position = player_position - dice;
        }

        if (player_poition < 0){
            player_position = 0;
        }

        Console.WriteLine("Player position: {player_position}");
        

    }
}