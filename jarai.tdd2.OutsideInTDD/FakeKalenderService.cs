namespace jarai.tdd2.OutsideInTDD;

public class FakeKalenderService : IKalenderService
{
    public DateTime ToDay()
    {
        return new DateTime(2023, 1, 1);
    }
}