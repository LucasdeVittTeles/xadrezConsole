using board;
using chess;

namespace xadrez_console
{
    class Program
    {
        private static void Main(string[] args)
        {
            PositionChess pos = new PositionChess('a', 1);
            PositionChess pos2 = new PositionChess('c', 7);

            int calc = 'c' - 'a';

            Console.WriteLine(pos);
            Console.WriteLine(pos2);
            Console.WriteLine(calc);

            Console.WriteLine(pos.ToPosition());
            Console.WriteLine(pos2.ToPosition());

        }
    }
}