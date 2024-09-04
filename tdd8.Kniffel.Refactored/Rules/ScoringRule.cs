namespace jarai.tdd8.KniffelRefactored.Rules;

public abstract class ScoringRule
{
    protected ScoringRule(ScoreId scoreId, string name)
    {
        Name = name;
        ScoreId = scoreId;
    }

    public string Name { get; private set; }

    public ScoreId ScoreId { get; private set; }


    public abstract int CalculateScore(Wurf wurf);
}