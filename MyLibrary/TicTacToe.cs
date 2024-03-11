namespace MyLibrary;

public class TicTacToe
{
    public enum Choices
    {
        Empty,
        X,
        O
    }
    public enum Places
    {
        topleft,
        top,
        middleright,
        topright,
        middleleft,
        middle,
        bottomleft,
        bottom,
        bottomright

    }
    public Places GetPlayerChoice()
    {
        Console.WriteLine("choose location");
        var input = Console.ReadLine();
        Places place;
        while (!Places.TryParse(input, out place))
        {
            Console.WriteLine("that is not a choice choose from:" +
                "        topleft,top,middleright,topright,middleleft,middle,bottomleft,bottom,bottomright");
            input = Console.ReadLine();
        }
        return place;
    }
    private Choices[,] Board { get; set; } = new Choices[3, 3];
    public void Asking()
    {
        Console.WriteLine("playerX");
        var place = GetPlayerChoice();
        switch (place)
        {
            case Places.top:
                Board[0, 1] = Choices.X;
                break;
            case Places.topleft:
                Board[0, 0] = Choices.X;
                break;
            case Places.topright:
                Board[0, 2] = Choices.X;
                break;
            case Places.middleleft:
                Board[1, 0] = Choices.X;
                break;
            case Places.middle:
                Board[1, 1] = Choices.X;
                break;
            case Places.middleright:
                Board[1, 2] = Choices.X;
                break;
            case Places.bottomleft:
                Board[2, 0] = Choices.X;
                break;
            case Places.bottom:
                Board[2, 1] = Choices.X;
                break;
            case Places.bottomright:
                Board[2, 2] = Choices.X;
                break;
        }
    }
    public void ShowBoard()
    {

        string board =
 @$"
      |        |      
   {Board[0, 0]}  |    {Board[0, 1]}   |    {Board[0, 2]}
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