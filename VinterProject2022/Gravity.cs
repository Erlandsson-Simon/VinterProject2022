public class Gravity
{
    public int gravity { get; set; } = 5;

    protected Vector2 movement;

    public Rectangle rect;

    private static List<Gravity> allGravities = new();

    // protected static Random generator = new();

    public Gravity()
    {
        allGravities.Add(this);
    }



    public void Update()
    {
        rect.x += movement.X;
        rect.y += movement.Y;

        rect.y += gravity;
    }

    public virtual void Draw()
    {
        R.DrawRectangleRec(rect, Color.BLUE);
    }

    public static void UpdateAll()
    {
        foreach (Gravity g in allGravities)
        {
            g.Update();
        }
    }

    public static void Drawall()
    {
        foreach (Gravity g in allGravities)
        {
            g.Draw();
        }
    }
}
