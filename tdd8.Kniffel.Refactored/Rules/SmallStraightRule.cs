namespace jarai.tdd8.KniffelRefactored.Rules;

public class SmallStraightRule : ScoringRule
{
    public SmallStraightRule() : base("Kleine Strasse")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        var counts = wurf.GetCounts();

        if (counts[0] >= 1 && counts[1] >= 1 && counts[2] >= 1 && counts[3] >= 1 && counts[4] >= 1)
            return 30;
        return 0;
    }
}