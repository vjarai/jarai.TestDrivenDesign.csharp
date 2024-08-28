namespace jarai.tdd8.KniffelRefactored
{
    public class CountRule : KniffelRuleBase
    {
        readonly int _count;

        public CountRule(int count)
        {
            _count = count;
        }

        public override int Calculate(params int[] dice)
        {
            return dice.Count(die => die == _count) * _count;
        }
    }
}
