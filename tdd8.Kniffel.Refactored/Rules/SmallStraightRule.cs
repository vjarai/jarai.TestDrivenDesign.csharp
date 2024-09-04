namespace jarai.tdd8.KniffelRefactored.Rules;

public class SmallStraightRule : ScoringRule
{
    public SmallStraightRule() : base(ScoringRuleId.SmallStraight, "Kleine Strasse")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        var counts = wurf.GetCounts();
        return counts.Count(c => c > 1) <= 1? 30 : 0;
    }
}