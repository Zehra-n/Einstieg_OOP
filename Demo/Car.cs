namespace Demo;

class Car : Vehicle, IMotorizedVehicle
{
    public int NumberOfDoors { get; }
    
    internal bool IsStartedEngine { get; private set; }
    

    public Car(string brand, string color, int numberOfDoors, VehicleCondition condition)
        : base(brand, color, condition)
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

    public void StartEngine()
    {
        if (!this.IsStartedEngine)
        {
            this.IsStartedEngine = true;
            Console.WriteLine("Motor des Autos gestartet!");
        }
        else
        {
            Console.WriteLine("Motor des Autos ist bereits gestartet!");
        }
    }

    public void StopEngine()
    {
        if (this.IsStartedEngine)
        {
            this.IsStartedEngine = false;
            Console.WriteLine("Motor des Autos gestoppt!");
        }
        else
        {
            Console.WriteLine("Motor des Autos ist bereits gestoppt!");
        }
    }
}