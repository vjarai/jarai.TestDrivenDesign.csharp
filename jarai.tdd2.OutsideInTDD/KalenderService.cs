namespace jarai.tdd2.OutsideInTDD;

internal class KalenderService : IKalenderService
{
    public DateTime Now()
    {
        return DateTime.Now;
    }
}