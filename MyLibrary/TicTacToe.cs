using MongoDB.Driver;

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
        topleft = 1,
        top,
        middleright,
        topright,
        middleleft,
        middle,
        bottomleft,
        bottom,
        bottomright

    }
    public void Choosing(Choices choice, Places place)
    {
        switch (place)
        {
            case Places.top:
                Board[0, 1] = choice;
                break;
            case Places.topleft:
                Board[0, 0] = choice;
                break;
            case Places.topright:
                Board[0, 2] = choice;
                break;
            case Places.middleleft:
                Board[1, 0] = choice;
                break;
            case Places.middle:
                Board[1, 1] = choice;
                break;
            case Places.middleright:
                Board[1, 2] = choice;
                break;
            case Places.bottomleft:
                Board[2, 0] = choice;
                break;
            case Places.bottom:
                Board[2, 1] = choice;
                break;
            case Places.bottomright:
                Board[2, 2] = choice;
                break;
        }
    }
    public Places GetPlayerChoice()
    {
        Console.WriteLine("choose location");
        var input = Console.ReadLine();
        int placeNumber;
        while (!int.TryParse(input, out placeNumber) || !(0<placeNumber&&placeNumber<10))
        {
            Console.WriteLine("that is not a choice choose from:" +
                "        topleft,top,middleright,topright,middleleft,middle,bottomleft,bottom,bottomright");
            input = Console.ReadLine();
        }
        return (Places)placeNumber;
    }
    private Choices[,] Board { get; set; } = new Choices[3, 3];
    public void Asking(string playerX, string playerO)
    {
        Console.WriteLine(playerX);
        var place = GetPlayerChoice();
        Choosing(Choices.X, place);
        Console.WriteLine(playerO);
        place = GetPlayerChoice();
        Choosing(Choices.O, place);
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