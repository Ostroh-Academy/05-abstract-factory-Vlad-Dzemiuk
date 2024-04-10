using System;

public abstract class Road
{
    public abstract void Build();
}

public class GravelRoad : Road
{
    public override void Build()
    {
        Console.WriteLine("Будуємо дорогу з грунтовим покриттям");
    }
}

public class AsphaltRoad : Road
{
    public override void Build()
    {
        Console.WriteLine("Будуємо дорогу з асфальтовим покриттям");
    }
}

public abstract class RoadFactory
{
    public abstract Road CreateRoad();
}

public class GravelRoadFactory : RoadFactory
{
    public override Road CreateRoad()
    {
        return new GravelRoad();
    }
}

public class AsphaltRoadFactory : RoadFactory
{
    public override Road CreateRoad()
    {
        return new AsphaltRoad();
    }
}

class Program
{
    static void Main(string[] args)
    {
        RoadFactory roadFactory;

        Console.WriteLine("Виберіть тип фабрики:");
        Console.WriteLine("1 - для створення доріг з грунтовим покриттям");
        Console.WriteLine("2 - для створення доріг з асфальтовим покриттям");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                roadFactory = new GravelRoadFactory();
                break;
            case 2:
                roadFactory = new AsphaltRoadFactory();
                break;
            default:
                Console.WriteLine("Невірний вибір");
                return;
        }

        Road road = roadFactory.CreateRoad();
        road.Build();
    }
}