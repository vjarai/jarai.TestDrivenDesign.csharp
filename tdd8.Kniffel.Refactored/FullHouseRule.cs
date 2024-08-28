namespace jarai.tdd8.KniffelRefactored
{
    public class FullHouseRule : KniffelRuleBase
    {
        public override int Calculate(params int[] dice)
        {
            var counts = new int[6];
            var hasThreeOfAKind = false;
            var hasPair = false;
            var score = 0;

            foreach (var die in dice)
                counts[die - 1]++;

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
}
