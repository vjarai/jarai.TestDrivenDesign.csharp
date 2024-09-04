namespace jarai.tdd8.KniffelRefactored.Rules;

public class KniffelRule : ScoringRule
{
    public KniffelRule() : base(ScoreId.Kniffel, "Kniffel")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        var counts = wurf.GetCounts();

        for (var i = 0; i != 6; i++)
        {
            if (counts[i] == 5)
                return 50;
        }

        return 0;
    }
}