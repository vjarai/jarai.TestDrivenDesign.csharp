namespace jarai.tdd8.KniffelRefactored
{
    public class SmallStraightRule : KniffelRuleBase
    {
        public override int Calculate(params int[] dice)
        {
            var counts = new int[6];
            foreach (var die in dice)
                counts[die - 1]++;
            if (counts[0] >= 1 && counts[1] >= 1 && counts[2] >= 1 && counts[3] >= 1 && counts[4] >= 1)
                return 15;
            return 0;
        }
    }
}
