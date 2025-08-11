// Product class
public class House
{
    public string Foundation { get; set; }
    public string Walls { get; set; }
    public string Roof { get; set; }

    public override string ToString()
    {
        return $"House with {Foundation} foundation, {Walls} walls, and {Roof} roof.";
    }
}

// Builder Interface
public interface IHouseBuilder
{
    void BuildFoundation();
    void BuildWalls();
    void BuildRoof();
    House GetHouse();
}

// Concrete Builder
public class ConcreteHouseBuilder : IHouseBuilder
{
    private House _house = new House();

    public void BuildFoundation()
    {
        _house.Foundation = "Concrete";
    }

    public void BuildWalls()
    {
        _house.Walls = "Brick";
    }

    public void BuildRoof()
    {
        _house.Roof = "Shingle";
    }

    public House GetHouse()
    {
        return _house;
    }
}

// Director
public class HouseDirector
{
    private IHouseBuilder _builder;

    public HouseDirector(IHouseBuilder builder)
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.BuildFoundation();
        _builder.BuildWalls();
        _builder.BuildRoof();
    }
}

// Usage
class Program
{
    static void Main()
    {
        IHouseBuilder builder = new ConcreteHouseBuilder();
        HouseDirector director = new HouseDirector(builder);

        director.Construct();
        House house = builder.GetHouse();

        Console.WriteLine(house);
        // Output: House with Concrete foundation, Brick walls, and Shingle roof.

        Console.ReadLine();
    }
}
