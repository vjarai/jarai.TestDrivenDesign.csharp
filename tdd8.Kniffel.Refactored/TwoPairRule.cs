namespace jarai.tdd8.KniffelRefactored
{
    public class TwoPairRule : KniffelRuleBase
    {
        public override int Calculate(params int[] dice)
        {
            var counts = new int[6];
            foreach (var die in dice)
                counts[die - 1]++;
            var n = 0;
            var score = 0;
            for (var i = 5; i >= 0; i--)
                if (counts[i] >= 2)
                {
                    n++;
                    score += (i + 1) * 2;
                }
            return n == 2 ? score : 0;
        }
    }
}
