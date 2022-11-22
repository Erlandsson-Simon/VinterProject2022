public class Player
{
    public Vector2 startingPos { get; set; } = new(960, 540);
    public Vector2 widthHight { get; set; } = new(50, 50);

    public Color playerColor { get; set; } = Color.BLACK;

    public int hp { get; set; } = 3;
    public int speed { get; set; } = 5;

    public Rectangle playerRect { get; set; }

    public Player()
    {
        playerRect = new(startingPos.X, 540, 50, 50);
    }
}
