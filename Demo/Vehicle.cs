namespace Demo;

class Vehicle : Abstract
{
    public Vehicle(string brand, string color) : base(brand, color) { }

    public override void Move()
    {
        Console.WriteLine($"{Brand} {Color} bewegt sich.");
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
    }
}