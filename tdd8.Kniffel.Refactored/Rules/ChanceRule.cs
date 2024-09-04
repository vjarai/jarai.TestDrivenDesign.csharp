namespace jarai.tdd8.KniffelRefactored.Rules;

public class ChanceRule : ScoringRule
{
    public ChanceRule() : base("Chance")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        return wurf.Sum();
    }
}