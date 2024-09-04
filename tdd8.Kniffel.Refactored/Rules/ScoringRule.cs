namespace jarai.tdd8.KniffelRefactored.Rules;

public abstract class ScoringRule
{
    protected ScoringRule(ScoringRuleId scoringRuleId, string name)
    {
        Name = name;
        ScoringRuleId = scoringRuleId;
    }

    public string Name { get; private set; }

    public ScoringRuleId ScoringRuleId { get; private set; }


    public abstract int CalculateScore(Wurf wurf);
}