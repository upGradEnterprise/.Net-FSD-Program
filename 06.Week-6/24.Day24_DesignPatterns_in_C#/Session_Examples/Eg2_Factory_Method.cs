public interface IShape
{
    void Draw();
}

public class Circle : IShape
{
    public void Draw() => Console.WriteLine("Drawing Circle");
}

public class Rectangle : IShape
{
    public void Draw() => Console.WriteLine("Drawing Rectangle");
}

public static class ShapeFactory
{
    public static IShape GetShape(string type)
    {
 
        return type.ToLower() switch
        {
            "circle" => new Circle(),
            "rectangle" => new Rectangle(),
            _ => throw new ArgumentException("Invalid shape type")
        };
        


        /*
        switch (type.ToLower())
        {
            case "circle": return new Circle();
            case "rectangle": return new Rectangle();
            default: throw new ArgumentException("Invalid shape type");
        }
        */
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Usage
        IShape shape;
        
        shape = ShapeFactory.GetShape("hello");
        shape.Draw();

         
        Console.ReadLine();
    }
}
