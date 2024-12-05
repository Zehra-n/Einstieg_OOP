namespace Demo;

class Mountainbike : Vehicle
{
    public int Year { get; }

    public Mountainbike(string brand, string color, int year, VehicleCondition condition)
        : base(brand, color, condition)
    {
        Year = year;
    }

    public override void Move()
    {
        Console.WriteLine($"Das Mountainbike {Brand}, {Color} mit Baujahr {Year}, fährt.");
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Baujahr: {Year}");
    }
}