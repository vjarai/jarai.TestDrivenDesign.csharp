namespace jarai.tdd8.KniffelRefactored.Rules;

public class LargeStraightRule : ScoringRule
{
    public LargeStraightRule() : base("Grosse Strasse")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        var counts = new int[6];
        foreach (int die in wurf)
        {
            counts[die - 1]++;
        }

        if (counts[1] >= 1 && counts[2] >= 1 && counts[3] >= 1 && counts[4] >= 1 && counts[5] >= 1)
            return 20;
        return 0;
    }
}