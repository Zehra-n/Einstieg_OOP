namespace Demo;

public class Motorcycle
{
    public string Brand { get; }
    public string Color { get; }
    public int Speed { get; }
    
    public Motorcycle(string brand, string color, int speed)
    {
        this.Brand = brand;
        this.Color = color;
        this.Speed = speed;
    }
    
    public void Move()
    {
        Console.WriteLine($"Das Motorrad {Brand} , {Color} fährt mit {Speed} km/h.");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Motorrad Info: {Brand} , {Color}, Geschwindigkeit: {Speed} km/h.");
    }
}