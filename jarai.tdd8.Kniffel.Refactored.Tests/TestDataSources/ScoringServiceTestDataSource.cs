using System.Collections;
using System.Collections.Generic;

namespace jarai.tdd8.KniffelRefactored.Tests.TestDataSources;

// https://andrewlock.net/creating-strongly-typed-xunit-theory-test-data-with-theorydata/

/// <summary>
///     External Class which returns the data for the [ClassData] parameterized Test
/// </summary>
public class ScoringServiceTestDataSource : IEnumerable<object[]>
{
    private readonly List<object[]> _data = new()
    {
        new object[] { 6, 6, 6, 6, 6, ScoreId.Sixes, 30 },
        new object[] { 5, 5, 5, 5, 5, ScoreId.Fives, 25 },
        new object[] { 4, 4, 4, 4, 5, ScoreId.Fours, 16 },
        new object[] { 3, 3, 3, 4, 5, ScoreId.Threes, 9 },
        new object[] { 2, 2, 1, 4, 2, ScoreId.Twos, 6 },
        new object[] { 1, 2, 1, 4, 1, ScoreId.Ones, 3 }
    };

    public IEnumerator<object[]> GetEnumerator()
    {
        return _data.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}