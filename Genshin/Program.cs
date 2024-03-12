using MyLibrary;

namespace Genshin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type name");
            var playerX = Console.ReadLine();
            Console.WriteLine("type name");
            var playerO = Console.ReadLine();
            var myClass = new MyClass();
            var greeting = myClass.GreetMe(playerX);
            Console.WriteLine(greeting);
            greeting = myClass.GreetMe(playerO);
            Console.WriteLine(greeting);
            var ticTacToe = new TicTacToe();
            ticTacToe.ShowBoard();
            while (true)
            {
                ticTacToe.Asking(playerX, playerO);
                ticTacToe.ShowBoard();
            };
        }
    }
}
