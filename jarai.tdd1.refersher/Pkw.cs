namespace jarai.tdd3.Stubbing;

public class Pkw
{
    public IMotor _motor;

    public Pkw(IMotor motor)
    {
        _motor = motor;
    }

    public double Tachostand { get; private set; }

    public void Fahren(double strecke)
    {
        _motor.Anlassen();

        Tachostand += strecke;

        _motor.Abstellen();
    }
}