using jarai.tdd8.KniffelRefactored.Rules;

namespace jarai.tdd8.KniffelRefactored;

public class KniffelScoringService
{
    private readonly Dictionary<ScoreId, ScoringRule> _rules;

    public KniffelScoringService()
    {

        var rules = new List<ScoringRule>
        {
            new CountRule(ScoreId.Ones, "Einer", 1),
            new CountRule(ScoreId.Twos, "Zweier", 2),
            new CountRule(ScoreId.Threes, "Dreier", 3),
            new CountRule(ScoreId.Fours, "Vierer", 4),
            new CountRule(ScoreId.Fives, "Fünfer", 5),
            new CountRule(ScoreId.Sixes, "Sechser", 6),

            new ThreeOfAKindRule(),
            new FourOfAKindRule(),
            new FullHouseRule(),
            new SmallStraightRule(),
            new LargeStraightRule(),
            new KniffelRule(),
            new ChanceRule(),
        };

        _rules = rules.ToDictionary(r => r.ScoreId, r => r);
    }


    public int CalculateScore(Wurf wurf, ScoreId rule)
    {
        return _rules[rule].CalculateScore(wurf);
    }

    public IEnumerable<ScoringResult> CalculateScorings(Wurf wurf)
    {
        return from rule in _rules.Values
               let result = rule.CalculateScore(wurf)
               where result > 0
               orderby result descending
               select new ScoringResult(rule.Name, result);
    }

}