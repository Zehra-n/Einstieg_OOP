namespace Demo;

class Car : Vehicle
{
    public int NumberOfDoors { get; }

    public Car(string brand, string color, int numberOfDoors)
        : base(brand, color)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void Move()
    {
        Console.WriteLine($"Das Auto {Brand} {Color} mit {NumberOfDoors} Türen fährt.");
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Türen: {NumberOfDoors}");
    }

    public void Honk()
    {
        Console.WriteLine("Tuuu Tuuu!");
    }
}