namespace jarai.tdd8.KniffelRefactored
{
    public class ScorePairRule : KniffelRuleBase
    {
        public override int Calculate(params int[] dice)
        {
            var counts = new int[6];
            foreach (var die in dice)
                counts[die - 1]++;
            for (var i = 5; i >= 0; i--)
                if (counts[i] >= 2)
                    return (i + 1) * 2;
            return 0;
        }
    }
}
