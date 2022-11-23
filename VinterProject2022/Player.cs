public class Player : Gravity
{
    private Vector2 startingPos = new(960, 540);
    private int width = 50;
    private int height = 50;

    public Color color { get; set; } = Color.BLACK;


    public int hp { get; set; } = 3;
    public int speed { get; set; } = 5;


    public Player()
    {
        rect = new Rectangle(startingPos.X, startingPos.Y, width, height);
    }

    public void HorizontalMovement()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            movement.X = speed;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            movement.X = -speed;
        }
        else
        {
            movement.X = 0;
        }
    }

    public void VerticalMovement()
    {

    }

    public override void Draw()
    {
        base.Draw();
        R.DrawRectangleLinesEx(rect, 3, color);
    }
}

