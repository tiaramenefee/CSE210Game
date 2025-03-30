public class Player : GameObject
{
    public Player(int x, int y) : base(x, y)
    {
        
    }
    public override void Draw()
    {
        Raylib.DrawRectangle(_x, _y, 50, 10, Color.Blue);
    }

    public override void Move(int dx, int dy)
    {
        _x += dx;
        _y += dy;
        Console.WriteLine($"Player moved to: {_x}, {_y}");
    }
}