namespace jarai.tdd0.Refresher;

public class Pkw
{
    private Motor _motor;

    public Pkw()
    {
        _motor = new Motor();
    }
    public Pkw(Motor motor)
    {
        _motor = motor;
    }

    public virtual void Fahren()
    {
        Console.WriteLine("Pkw fährt");
    }
}