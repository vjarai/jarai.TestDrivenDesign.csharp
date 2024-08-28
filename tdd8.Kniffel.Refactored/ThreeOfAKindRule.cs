namespace jarai.tdd8.KniffelRefactored
{
    public class ThreeOfAKindRule : KniffelRuleBase
    {
        public override int Calculate(params int[] dice)
        {
            var counts = new int[6];
            foreach (var die in dice)
                counts[die - 1]++;
            for (var i = 0; i < 6; i++)
                if (counts[i] >= 3)
                    return (i + 1) * 3;
            return 0;
        }
    }
}
