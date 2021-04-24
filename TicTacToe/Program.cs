using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static char[,] field = new char[3, 3];

        const char PLAYER_X = 'X';
        const char PLAYER_O = 'O';

        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                DrawField();
                Console.WriteLine(" Введите X.");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(" Введите Y.");
                int y = int.Parse(Console.ReadLine());
                field[x - 1, y - 1] = PLAYER_X;
            }
        }

        public static void DrawField()
        {
            Console.Clear();
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + field[i, j] + " ");                   
                }
                Console.WriteLine();
            }
        }

    }
}
