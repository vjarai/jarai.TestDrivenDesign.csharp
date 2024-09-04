namespace jarai.tdd8.KniffelRefactored.Rules;

public abstract class ScoringRule
{
    protected ScoringRule(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }


    public abstract int CalculateScore(Wurf wurf);
}