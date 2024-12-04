namespace Demo;

public class Mountainbike
{
    public string Brand { get; }
    public string Color { get; }
    public int Year { get; }
    
    public Mountainbike(string brand, string color, int year)
    {
        this.Brand = brand;
        this.Color = color;
        this.Year = year;
    }
    
    public void Move()
    {
        Console.WriteLine($"Der Mountainbike {Brand} , {Color} mit Baujahr {Year}, fährt.");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Mountainbike Info: {Brand} , {Color}, Baujahr: {Year}.");
    }
}