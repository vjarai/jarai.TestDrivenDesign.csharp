namespace jarai.tdd9.Kniffel.ScoringRules;

public class KniffelRule : ScoringRule
{
    public KniffelRule() : base(ScoreId.Kniffel, "Kniffel")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        int[] counts = wurf.GetCounts();

        return counts.Any(c => c == 5) ? 50 : 0;

    }
}