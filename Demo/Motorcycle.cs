namespace Demo;

class Motorcycle : Vehicle
{
    public int Speed { get; }

    public Motorcycle(string brand, string color, int speed)
        : base(brand, color)
    {
        Speed = speed;
    }

    public override void Move()
    {
        Console.WriteLine($"Das Motorrad {Brand}, {Color} fährt mit {Speed} km/h.");
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Geschwindigkeit: {Speed} km/h");
    }
}