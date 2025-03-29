using Raylib_cs;

public class Player : GameObject
{
    private int _width;
    private int _height;
    public Player(int x, int y) : base(x, y, Color.Blue)
    {
        _width = 50;
        _height = 5;
        _color = Color.Blue;
    }

    public override void Draw()
    {
       Raylib.DrawRectangle(_x,_y,_width,_height, Color.Blue);
    }

    public override void ProcessActions()
    {
        if (Raylib.IsKeyDown(KeyboardKey.Right) && _x < 800 - _width)
        {
            _x += 8;
        }
        if (Raylib.IsKeyDown(KeyboardKey.Left) && _x > 0)
        {
            _x -= 8;
        }
    }

   

}