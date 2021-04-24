using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static char[,] field = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };

        const char PLAYER_X = 'X';
        const char PLAYER_O = 'O';

        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                DrawField();
                Console.WriteLine(" Введите координаты, например: 22.");
                string coords = Console.ReadLine();

                field[coords[0] - 1, coords[1] - 1] = PLAYER_X;
                
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
