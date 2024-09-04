namespace jarai.tdd8.KniffelRefactored.Rules;

public class FourOfAKindRule : ScoringRule
{
    public FourOfAKindRule() : base(ScoringRuleId.FourOfAKind, "Vierer Pasch")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        var counts = wurf.GetCounts();

        for (var i = 0; i < 6; i++)
        {
            if (counts[i] >= 4)
                return wurf.Sum();
        }

        return 0;
    }
}