namespace Demo;

class Vehicle : Abstract
{
        public Vehicle(string brand, string color, VehicleCondition condition) : base(brand, color)
    {
        this.Condition = condition;
        this.Brand = brand;
        this.Color = color;
    }   

    public override void Move()
    {
        Console.WriteLine($"{this.Brand} {this.Color} bewegt sich.");
    }
    
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Marke: {this.Brand} , Farbe:  {this.Color}. Zustand: {this.Condition}.");
    }
}