using Raylib_cs;


public abstract class GameObject
{
    protected int _x;
    protected int _y;
    protected Color _color;

    public GameObject(int x, int y, Color color)
    {
        _x = x;
        _y = y;
        _color = color;
    }

    public abstract void Draw();

  
    public virtual void HandleInput()
    {
        


     }
    public virtual void ProcessActions() 
    {   


    }
}