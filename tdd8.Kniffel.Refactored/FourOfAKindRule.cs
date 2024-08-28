namespace jarai.tdd8.KniffelRefactored
{
    public class FourOfAKindRule : KniffelRuleBase
    {
        public override int Calculate(params int[] dice)
        {
            var counts = new int[6];
            foreach (var die in dice)
                counts[die - 1]++;
            for (var i = 0; i < 6; i++)
                if (counts[i] >= 4)
                    return (i + 1) * 4;
            return 0;
        }
    }
}
