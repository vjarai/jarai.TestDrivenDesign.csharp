namespace jarai.tdd9.Kniffel;

public class ScoringResult
{
    public ScoringResult(ScoreId scoreId, int result, string? ruleName = null)
    {
        ScoreId = scoreId;
        RuleName = ruleName ?? scoreId.ToString();
        Result = result;
    }

    public ScoreId ScoreId { get; }
    public string RuleName { get; }
    public int Result { get; }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType()) return false;

        var other = (ScoringResult)obj;

        return other.Equals(this);
    }

    protected bool Equals(ScoringResult other)
    {
        return ScoreId == other.ScoreId && Result == other.Result;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(RuleName, Result);
    }

    public override string ToString()
    {
        return $"{Result:d2} : {RuleName}";
    }
}