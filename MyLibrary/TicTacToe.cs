namespace MyLibrary;

public class TicTacToe
{
    public enum Choices
    {
        Empty,
        X,
        O
    }
    private Choices[,] Board { get; set; } = new Choices[3,3];
    public void ShowBoard()
    {
        Console.WriteLine("p1: what square?");
        var first = Console.ReadLine();
        Console.WriteLine("p2: what square?");
        var second = Console.ReadLine();
        var topleft = Board[0, 0] = Choices.O;
        var top = Board[0, 1] = Choices.O;
        var topright = Board[0, 2] = Choices.O;
        var left = Board[1, 0] = Choices.O;
        var middle = Board[1, 1] = Choices.O;
        var right = Board[1, 2] = Choices.O;
        var bottomleft = Board[2, 0] = Choices.O;
        var bottom = Board[2, 1] = Choices.O;
        var bottomright = Board[2, 2] = Choices.O;
        string board =
 @$"
      |        |      
   {Board[0,0]}  |    {Board[0, 1]}   |    {Board[0, 2]}
______|________|________
      |        |
   {Board[1, 0]}  |    {Board[1, 1]}   |    {Board[1, 2]}
______|________|________
      |        |
   {Board[2, 0]}  |    {Board[2, 1]}   |    {Board[2, 2]}
      |        |";
        Console.WriteLine(board);

    }
}