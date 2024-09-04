namespace jarai.tdd8.KniffelRefactored;

public class ScoringResult
{
    private readonly string _ruleName;
    private readonly int _result;

    public ScoringResult(string ruleName, int result)
    {
        _ruleName = ruleName;
        _result = result;
    }

    public override string ToString()
    {
        return $"{_result:d2} : {_ruleName}";
    }
}