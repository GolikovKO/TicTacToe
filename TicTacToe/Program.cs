using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static int[,] field = new int[3, 3] { { 3, 3, 3 }, { 3, 3, 3 }, { 3, 3, 3} }; // Чтобы массив был пустым при отрисовке, заполняем его 
                                                                    //любыми значениями, кроме 1 и 0 потому что это коды для крестика и нолика.
        const int PLAYER_X = 1;
        const int PLAYER_O = 0;

        static bool flag = false;

        static int current = PLAYER_X;

        static void Main(string[] args)
        {
            for (int i = 0; i < 9; ++i)
            {
                DrawField();
                Console.WriteLine(" Ход номер " + (i + 1));
                Console.WriteLine(" Ходит " + GetPlayer(current));
                Console.WriteLine(" Введите X.");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(" Введите Y.");
                int y = int.Parse(Console.ReadLine());

                if ((x < 1) || (x > 3) || (y < 1) || (y > 3))
                {
                    Console.WriteLine(" Недопустимые координаты.");
                    Thread.Sleep(900);
                    i--;
                    continue;
                }

                if ((field[x - 1, y - 1] == PLAYER_O) || (field[x - 1, y - 1] == PLAYER_X))
                {
                    Console.WriteLine(" Координаты заняты.");
                    Thread.Sleep(900);
                    i--;
                    continue;
                }

                if (i > 7)
                {
                    Console.WriteLine(" Никто не выиграл.");
                    Thread.Sleep(1300);
                    break;
                }

                field[x - 1, y - 1] = current;

                flag = Check(current);
                if (flag)
                {
                    DrawField();
                    Console.WriteLine(" Победитель " + GetPlayer(current) + " !");
                    Thread.Sleep(3000);
                    break;
                }
                current = (current == 1) ? 0 : 1;
            }
        }

        static bool Check(int current)
        {
            if
                (

                ((field[0, 0] == field[0, 1]) && (field[0, 0] == current) && (field[0, 1] == field[0, 2])) || // первая строчка
                ((field[1, 0] == field[1, 1]) && (field[1, 0] == current) && (field[1, 1] == field[1, 2])) || // вторая строчка
                ((field[2, 0] == field[2, 1]) && (field[2, 0] == current) && (field[2, 1] == field[2, 2])) || // третья строчка

                ((field[0, 0] == field[1, 0]) && (field[1, 0] == current) && (field[1, 0] == field[2, 0])) || // первый столбик
                ((field[0, 1] == field[1, 1]) && (field[1, 1] == current) && (field[1, 1] == field[2, 1])) || // второй столбик
                ((field[0, 2] == field[1, 2]) && (field[1, 2] == current) && (field[1, 2] == field[2, 2])) || // третий столбик

                ((field[0, 0] == field[1, 1]) && (field[1, 1] == current) && (field[1, 1] == field[2, 2])) || // диагональ из 11 в 33
                ((field[0, 2] == field[1, 1]) && (field[1, 1] == current) && (field[1, 1] == field[2, 0]))    // диагональ из 13 в 31

                )          
                return true;
            else
                return false;
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