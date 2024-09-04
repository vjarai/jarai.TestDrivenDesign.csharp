namespace jarai.tdd8.KniffelRefactored.Rules;

public class FullHouseRule : ScoringRule
{
    public FullHouseRule() : base("Full House")
    {
    }

    public override int CalculateScore(Wurf wurf)
    {
        var counts = wurf.GetCounts();
      
        var hasThreeOfAKind = false;
        var hasPair = false;
        var score = 0;

      

        for (var i = 0; i < 6; i++)
        {
            if (counts[i] == 3)
            {
                hasThreeOfAKind = true;
                score += (i + 1) * 3;
            }

            if (counts[i] == 2)
            {
                hasPair = true;
                score += (i + 1) * 2;
            }
        }

        return hasThreeOfAKind && hasPair ? score : 0;
    }
}