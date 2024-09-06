namespace jarai.tdd9.Kniffel.ScoringRules;

public abstract class ScoringRule
{
    /// <summary>
    ///     Default Construktor needed for Moq mocking
    /// </summary>
    public ScoringRule()
    {
    }

    protected ScoringRule(ScoreId scoreId, string name)
    {
        Name = name;
        ScoreId = scoreId;
    }

    public string Name { get; private set; }

    public ScoreId ScoreId { get; private set; }


    public abstract int CalculateScore(Wurf wurf);
}