using System.ComponentModel;

namespace MyLibrary.Games;

public class Board
{
    public enum Choices
    {
        [Description(" ")] Empty,
        [Description("X")] X,
        [Description("O")] O
    }

    public enum Positions
    {
        Left,
        Center,
        Right
    }

    public enum Rows
    {
        Top,
        Middle,
        Bottom
    }
    private Choices[,] ChoiceArray { get; } = new Choices[3, 3];

    public Choices GetChoice(Rows row, Positions position) => ChoiceArray[(int)row, (int)position];
    public string this[Rows row, Positions position] =>
        typeof(Choices).GetField(Enum.GetName(typeof(Choices), GetChoice(row, position)) ?? string.Empty)
            ?.GetCustomAttributes(false)
            .OfType<DescriptionAttribute>()
            .SingleOrDefault()
            ?.Description;

    public void SetChoice(Rows row, Positions position, Choices choice) => ChoiceArray[(int)  row, (int)position] = choice;

    public void ShowBoard()
    {
        var board =
            @$"
          │        │      
       {this[Rows.Top, Positions.Left]}  │    {this[Rows.Top, Positions.Center]}   │    {this[Rows.Top, Positions.Right]}
          │        │
    ──────┼────────┼────────
          │        │
       {this[Rows.Middle, Positions.Left]}  │    {this[Rows.Middle, Positions.Center]}   │    {this[Rows.Middle, Positions.Right]}
          │        │
    ──────┼────────┼────────
          │        │
       {this[Rows.Bottom, Positions.Left]}  │    {this[Rows.Bottom, Positions.Center]}   │    {this[Rows.Bottom, Positions.Right]}
          │        │
";
        Console.WriteLine(board);
    }
}