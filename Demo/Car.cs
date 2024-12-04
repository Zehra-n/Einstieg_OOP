using System.Drawing;

namespace Demo;

class Car
{
    public string Brand { get; }
    public string Color { get; }
    public int NumberOfDoors { get; }

    public Car(string brand, string color, int numberOfDoors)
    {
        this.Brand = brand;
        this.Color = color;
        this.NumberOfDoors = numberOfDoors;
    }
    
   
    public void Move()
    {
        Console.WriteLine($"Das Auto {Brand} {Color} mit {NumberOfDoors} Türen fährt.");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Auto Info: {Brand} {Color}, Türen: {NumberOfDoors}");
    }
}

