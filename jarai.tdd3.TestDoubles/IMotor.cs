namespace jarai.tdd3.TestDoubles;

public interface IMotor
{
    int Drehzahl { get; set; }
    void Anlassen();
    void Abstellen();
}