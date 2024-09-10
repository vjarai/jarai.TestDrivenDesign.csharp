namespace jarai.tdd3.TestDoubles;

public interface IMotor
{
    int Drehzahl { get; }
    void Anlassen();
    void Abstellen();
}