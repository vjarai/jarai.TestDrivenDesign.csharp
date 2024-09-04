namespace jarai.tdd8.KniffelRefactored.Rules;

public class LargeStraightRule : ScoringRule
{
    public LargeStraightRule() : base("Grosse Strasse")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        var counts = wurf.GetCounts();

        return counts.All(c => c <= 1)? 40 : 0;

    }
}