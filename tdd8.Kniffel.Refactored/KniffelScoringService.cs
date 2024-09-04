using jarai.tdd8.KniffelRefactored.Rules;

namespace jarai.tdd8.KniffelRefactored;

public class KniffelScoringService
{
    private readonly Dictionary<ScoringRuleId, ScoringRule> _rules;

    public KniffelScoringService()
    {

        var rules = new List<ScoringRule>
        {
            new CountRule(ScoringRuleId.Ones, "Einer", 1),
            new CountRule(ScoringRuleId.Twos, "Zweier", 2),
            new CountRule(ScoringRuleId.Threes, "Dreier", 3),
            new CountRule(ScoringRuleId.Fours, "Vierer", 4),
            new CountRule(ScoringRuleId.Fives, "Fünfer", 5),
            new CountRule(ScoringRuleId.Sixes, "Sechser", 6),

            new ThreeOfAKindRule(),
            new FourOfAKindRule(),
            new FullHouseRule(),
            new SmallStraightRule(),
            new LargeStraightRule(),
            new KniffelRule(),
            new ChanceRule(),
        };

        _rules = rules.ToDictionary(r => r.ScoringRuleId, r => r);
    }


    public int CalculateScore(Wurf wurf, ScoringRuleId rule)
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