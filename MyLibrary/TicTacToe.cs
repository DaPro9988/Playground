namespace MyLibrary;

public class TicTacToe
{
    public enum Choices
    {
        Empty,
        X,
        O
    }
    public enum choice
    {
        topleft
            top
            topright
            topleft
            middleleft
            middle

    }
    private Choices[,] Board { get; set; } = new Choices[3,3];
   public void Asking()
    {
        Console.WriteLine("p1: what square?");
        var first = Console.ReadLine();
        if (first.ToLower() == "top".ToLower())
            Board[0, 0] = Choices.X;
        Console.WriteLine("p2: what square?");
        var second = Console.ReadLine();
        //Board[0, 0] = Choices.O;
        Board[0, 1] = Choices.O;
        Board[0, 2] = Choices.O;
        Board[1, 0] = Choices.O;
        Board[1, 1] = Choices.O;
        Board[1, 2] = Choices.O;
        Board[2, 0] = Choices.O;
        Board[2, 1] = Choices.O;
        Board[2, 2] = Choices.O;
    }
    public void ShowBoard()
    {

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