using jarai.tdd8.KniffelRefactored.Rules;

namespace jarai.tdd8.KniffelRefactored;

public class KniffelScoringService
{
    private readonly IEnumerable<ScoringRule> _rules;

    public KniffelScoringService()
    {
        _rules = new List<ScoringRule>
        {
            new CountRule(ScoreId.Ones, "Einer", 1),
            new CountRule(ScoreId.Twos, "Zweier", 2),
            new CountRule(ScoreId.Threes, "Dreier", 3),
            new CountRule(ScoreId.Fours, "Vierer", 4),
            new CountRule(ScoreId.Fives, "F�nfer", 5),
            new CountRule(ScoreId.Sixes, "Sechser", 6),

            new ThreeOfAKindRule(),
            new FourOfAKindRule(),
            new FullHouseRule(),
            new SmallStraightRule(),
            new LargeStraightRule(),
            new KniffelRule(),
            new ChanceRule()
        };
    }


    public KniffelScoringService(params ScoringRule[] rules)
    {
        _rules = rules;
    }

    public int CalculateScore(ScoreId scoreId, Wurf wurf)
    {
        var rule = _rules.Single(r => r.ScoreId == scoreId);

        return rule.CalculateScore(wurf);
    }

    public IEnumerable<ScoringResult> CalculateScorings(Wurf wurf)
    {
        return from rule in _rules
            let result = rule.CalculateScore(wurf)
            where result > 0
            orderby result descending
            select new ScoringResult(rule.ScoreId, result, rule.Name);
    }
}