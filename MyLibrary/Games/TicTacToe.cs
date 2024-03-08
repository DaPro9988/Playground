namespace MyLibrary.Games;

public class TicTacToe
{
    private Board Board { get; } = new();
    public void StartGame()
    {
        Board.SetChoice(Board.Rows.Middle, Board.Positions.Center, Board.Choices.X);
        Board.ShowBoard();
    }
}