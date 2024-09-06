namespace jarai.tdd9.Kniffel.ScoringRules;

public class LargeStraightRule : ScoringRule
{
    public LargeStraightRule() : base(ScoreId.LargeStraight, "Grosse Strasse")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        return wurf.GetCounts().Order().Skip(1).All(count => count == 1) ? 40 : 0;
    }
}