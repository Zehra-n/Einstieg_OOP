namespace Demo;

abstract class Abstract
{
    public string Brand { get; set; }
    public string Color { get; set; }

    public Abstract(string brand, string color)
    {
        Brand = brand;
        Color = color;
    }
    
    public abstract void Move();
    
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Fahrzeug Info: Marke: {Brand}, Farbe: {Color}");
    }
}