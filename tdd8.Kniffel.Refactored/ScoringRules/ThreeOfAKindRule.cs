namespace jarai.tdd9.Kniffel.ScoringRules;

public class ThreeOfAKindRule : ScoringRule
{
    public ThreeOfAKindRule() : base(ScoreId.ThreeOfAKind, "Dreier Pasch")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        int[] counts = wurf.GetCounts();

        for (var i = 0; i < 6; i++)
        {
            if (counts[i] >= 3)
                return wurf.Sum();
        }

        return 0;
    }
}