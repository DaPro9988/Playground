using MyLibrary;
using MyLibrary.Games;

namespace Genshin;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("type name");
        //var name = Console.ReadLine();
        //var myClass = new MyClass();
        //var greeting = myClass.GreetMe(name);
        //Console.WriteLine(greeting);
        var ticTacToe = new TicTacToe();
        ticTacToe.StartGame();
    }
}