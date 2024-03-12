using MongoDB.Driver;
using System.ComponentModel;

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
    public string GetDescription(Choices choice)
    {
        return typeof(Choices).GetField(Enum.GetName(typeof(Choices), choice))
            ?.GetCustomAttributes(false)
            .OfType<DescriptionAttribute>()
            .SingleOrDefault()
            ?.Description;
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
   {GetDescription(Board[0, 0])}1  |    {GetDescription(Board[0, 1])}2   |    {GetDescription(Board[0, 2])}3
______|________|________
      |        |
   {GetDescription(Board[1, 0])}4  |    {GetDescription(Board[1, 1])}5   |    {GetDescription(Board[1, 2])}6
______|________|________
      |        |
   {GetDescription(Board[2, 0])}7  |    {GetDescription(Board[2, 1])}8   |    {GetDescription(Board[2, 2])}9
      |        |";
        Console.WriteLine(board);

    }
}