namespace jarai.tdd8.KniffelRefactored
{
    public class KniffelCalculator
    {
        private readonly Dictionary<string, KniffelRuleBase> _rules;

        public KniffelCalculator()
        {
            _rules = new Dictionary<string, KniffelRuleBase>
            {
                { "Chance", new ChanceRule() },
                { "Kniffel", new KniffelRule() },
                { "Ones", new CountRule(1) },
                { "Twos", new CountRule(2) },
                { "Threes", new CountRule(3) },
                { "Fours", new CountRule(4) },
                { "Fives", new CountRule(5) },
                { "Sixes", new CountRule(6) },
                { "ScorePair", new ScorePairRule() },
                { "TwoPair", new TwoPairRule() },
                { "FourOfAKind", new FourOfAKindRule() },
                { "ThreeOfAKind", new ThreeOfAKindRule() },
                { "SmallStraight", new SmallStraightRule() },
                { "LargeStraight", new LargeStraightRule() },
                { "FullHouse", new FullHouseRule() }
            };
        }

        public int Chance(int d1, int d2, int d3, int d4, int d5)
        {
            return _rules["Chance"].Calculate(d1, d2, d3, d4, d5);
        }

        public int Kniffel(params int[] dice)
        {
            return _rules["Kniffel"].Calculate(dice);
        }

        public int Ones(int d1, int d2, int d3, int d4, int d5)
        {
            return _rules["Ones"].Calculate(d1, d2, d3, d4, d5);
        }

        public int Twos(int d1, int d2, int d3, int d4, int d5)
        {
            return _rules["Twos"].Calculate(d1, d2, d3, d4, d5);
        }

        public int Threes(int d1, int d2, int d3, int d4, int d5)
        {
            return _rules["Threes"].Calculate(d1, d2, d3, d4, d5);
        }

        protected int[] dice;
        public KniffelCalculator(int d1, int d2, int d3, int d4, int _5) : this()
        {
            dice = new int[5];
            dice[0] = d1;
            dice[1] = d2;
            dice[2] = d3;
            dice[3] = d4;
            dice[4] = _5;
        }

        public int Fours()
        {
            return _rules["Fours"].Calculate(dice);
        }

        public int Fives()
        {
            return _rules["Fives"].Calculate(dice);
        }

        public int Sixes()
        {
            return _rules["Sixes"].Calculate(dice);
        }

        public int ScorePair(int d1, int d2, int d3, int d4, int d5)
        {
            return _rules["ScorePair"].Calculate(d1, d2, d3, d4, d5);
        }

        public int TwoPair(int d1, int d2, int d3, int d4, int d5)
        {
            return _rules["TwoPair"].Calculate(d1, d2, d3, d4, d5);
        }

        public int FourOfAKind(int _1, int _2, int d3, int d4, int d5)
        {
            return _rules["FourOfAKind"].Calculate(_1, _2, d3, d4, d5);
        }

        public int ThreeOfAKind(int d1, int d2, int d3, int d4, int d5)
        {
            return _rules["ThreeOfAKind"].Calculate(d1, d2, d3, d4, d5);
        }

        public int SmallStraight(int d1, int d2, int d3, int d4, int d5)
        {
            return _rules["SmallStraight"].Calculate(d1, d2, d3, d4, d5);
        }

        public int LargeStraight(int d1, int d2, int d3, int d4, int d5)
        {
            return _rules["LargeStraight"].Calculate(d1, d2, d3, d4, d5);
        }

        public int FullHouse(int d1, int d2, int d3, int d4, int d5)
        {
            return _rules["FullHouse"].Calculate(d1, d2, d3, d4, d5);
        }
    }
}
