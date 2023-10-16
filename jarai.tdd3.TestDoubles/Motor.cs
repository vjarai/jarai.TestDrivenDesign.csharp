namespace jarai.tdd3.TestDoubles;

public class Motor : IMotor
{
    public int Drehzahl { get; set; }

    public void Anlassen()
    {
        Drehzahl = 1000;
    }

    public void Abstellen()
    {
        Drehzahl = 0;
    }
}