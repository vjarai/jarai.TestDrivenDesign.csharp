namespace jarai.tdd8.KniffelRefactored.Rules;

public class FullHouseRule : ScoringRule
{
    public FullHouseRule() : base(ScoringRuleId.FullHouse, "Full House")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        var counts = wurf.GetCounts();

        return counts.Any(c => c == 3) && counts.Any(c => c == 2) ? 25 : 0;

    }
}