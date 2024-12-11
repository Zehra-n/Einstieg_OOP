namespace Demo;

public class Engine
{
    public double AmountLiter { get; }
    public int Horsepower { get; }
    public bool IsStarted { get; set; }

    public Engine(double amountLiter, int horsepower)
    {
        this.AmountLiter = amountLiter;
        this.Horsepower = horsepower;
        this.IsStarted = false;
    }

    protected bool Equals(Engine other)
    {
        return AmountLiter.Equals(other.AmountLiter) && Horsepower == other.Horsepower;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        Engine other = (Engine) obj;
        return this.AmountLiter.Equals(other.AmountLiter) && this.Horsepower == other.Horsepower;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(AmountLiter, Horsepower);
    }

    public override string ToString()
    {
        return $"AmountLiter: {AmountLiter}, Horsepower: {Horsepower}, Gestartet: {IsStarted}";
    }

    private Engine engine1 = new Engine(amountLiter: 1.8, horsepower: 100);
    private Engine engine2 = new Engine(amountLiter: 2.0, horsepower: 200);
    private Engine engine3 = new Engine(amountLiter: 1.8, horsepower: 100);

}