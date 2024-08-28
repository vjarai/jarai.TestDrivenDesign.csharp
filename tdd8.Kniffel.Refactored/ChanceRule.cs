namespace jarai.tdd8.KniffelRefactored
{
    public class ChanceRule : KniffelRuleBase
    {
        public override int Calculate(params int[] dice)
        {
            var total = 0;
            foreach (var die in dice)
            {
                total += die;
            }
            return total;
        }
    }
}
