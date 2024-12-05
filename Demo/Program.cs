namespace Demo;

class Program
{
    static void Main(string[] args)
    {

        Vehicle vehicle1 = new Car("Porsche", "Blue", 2, VehicleCondition.New);
        List<Vehicle> vehicles = [vehicle1];
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.PrintInfo();
        }
        
        Car car = new Car("BMW", "Black", 4, VehicleCondition.New);
        car.PrintInfo();
        car.Move();
        car.StartEngine();
        car.StopEngine();
        
        Motorcycle motorcycle = new Motorcycle("BMW", "White/Blue/Red", 250, VehicleCondition.LightlyUsed);
        motorcycle.PrintInfo();
        motorcycle.Move();
        
        Mountainbike mountainbike = new Mountainbike("Aventon", "Brown", 2023, VehicleCondition.HeavilyUsed);
        mountainbike.PrintInfo();
        mountainbike.Move();
    }
}