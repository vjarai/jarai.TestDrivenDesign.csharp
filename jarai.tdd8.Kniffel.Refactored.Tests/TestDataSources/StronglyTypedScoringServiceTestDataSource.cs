using Xunit;

namespace jarai.tdd8.Kniffel.Tests.TestDataSources;

// https://andrewlock.net/creating-strongly-typed-xunit-theory-test-data-with-theorydata/

public class StronglyTypedScoringServiceTestDataSource : TheoryData<Wurf, ScoreId, int>
{
    public StronglyTypedScoringServiceTestDataSource()
    {
        Add(new Wurf(6, 6, 6, 6, 6), ScoreId.Sixes, 30);
        Add(new Wurf(5, 5, 5, 5, 5), ScoreId.Fives, 25);
        Add(new Wurf(4, 4, 4, 4, 5), ScoreId.Fours, 16);
        Add(new Wurf(3, 3, 3, 4, 5), ScoreId.Threes, 9);
        Add(new Wurf(2, 2, 1, 4, 2), ScoreId.Twos, 6);
        Add(new Wurf(1, 2, 1, 4, 1), ScoreId.Ones, 3);
    }
}