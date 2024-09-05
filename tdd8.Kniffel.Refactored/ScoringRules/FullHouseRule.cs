namespace jarai.tdd8.Kniffel.ScoringRules;

public class FullHouseRule : ScoringRule
{
    public FullHouseRule() : base(ScoreId.FullHouse, "Full House")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        int[] counts = wurf.GetCounts();

        return counts.Any(c => c == 3) && counts.Any(c => c == 2) ? 25 : 0;
    }
}