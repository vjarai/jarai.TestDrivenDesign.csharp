namespace jarai.tdd8.KniffelRefactored.Rules;

public class ThreeOfAKindRule : ScoringRule
{
    public ThreeOfAKindRule() : base("Dreier Pasch")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        var counts = wurf.GetCounts();

        for (var i = 0; i < 6; i++)
        {
            if (counts[i] >= 3)
                return (i + 1) * 3;
        }

        return 0;
    }
}