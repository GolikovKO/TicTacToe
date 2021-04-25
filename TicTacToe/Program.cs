using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static int[,] field = new int[3, 3] { { 3, 3, 3 }, { 3, 3, 3 }, { 3, 3, 3} }; // Чтобы массив был пустым при отрисовке, заполняем его 
                                                                    //любыми значениями, кроме 1 и 0 потому что это коды для крестика и нолика.
        const int PLAYER_X = 1;
        const int PLAYER_O = 0;

        static int current = PLAYER_X;

        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                DrawField();
                Console.WriteLine(" Ходит " + GetPlayer(current));
                Console.WriteLine(" Введите X.");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(" Введите Y.");
                int y = int.Parse(Console.ReadLine());
                field[x - 1, y - 1] = current;
                current = (current == 1) ? 0 : 1;
            }
        }

        static string GetPlayer(int player)
        {
            switch (player)
            {
                case PLAYER_O: {
                    return "O";
                    }
                case PLAYER_X: {
                    return "X";
                    }
                default: return " ";
            }
        }

        static void DrawField()
        {
            Console.Clear();
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + GetPlayer(field[i, j]) + " ");                   
                }
                Console.WriteLine();
            }
        }

    }
}
