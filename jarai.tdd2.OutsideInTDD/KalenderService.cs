namespace jarai.tdd2.OutsideInTDD;

internal class KalenderService : IKalenderService
{
    public DateTime ToDay()
    {
        return DateTime.Now;
    }
}