namespace jarai.tdd8.Kniffel.ScoringRules;

public class ChanceRule : ScoringRule
{
    public ChanceRule() : base(ScoreId.Chance, "Chance")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        return wurf.Sum();
    }
}