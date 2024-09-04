namespace jarai.tdd8.KniffelRefactored.Rules;

public class FourOfAKindRule : ScoringRule
{
    public FourOfAKindRule() : base("Vierer Pasch")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        var counts = wurf.GetCounts();

        for (var i = 0; i < 6; i++)
        {
            if (counts[i] >= 4)
                return (i + 1) * 4;
        }

        return 0;
    }
}