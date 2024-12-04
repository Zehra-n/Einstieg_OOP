namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("BMW", "Black", 4);
        car.PrintInfo();
        car.Move();
        car.Honk();
        
        Motorcycle motorcycle = new Motorcycle("BMW", "White/Blue/Red", 250);
        motorcycle.PrintInfo();
        motorcycle.Move();
        
        Mountainbike mountainbike = new Mountainbike("Aventon", "Brown", 2023);
        mountainbike.PrintInfo();
        mountainbike.Move();
    }
}