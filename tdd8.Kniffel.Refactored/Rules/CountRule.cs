namespace jarai.tdd8.KniffelRefactored.Rules;

public class CountRule : ScoringRule
{
    private readonly int _wert;

    public CountRule(ScoringRuleId ruleId, string name, int wert) : base(ruleId, name)
    {
        _wert = wert;
    }

    public override int CalculateScore(Wurf wurf)
    {
        return wurf.Count(die => die == _wert) * _wert;
    }
}