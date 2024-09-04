using jarai.tdd8.KniffelRefactored.Rules;

namespace jarai.tdd8.KniffelRefactored;

public class KniffelScoringService
{
    private readonly Dictionary<string, ScoringRule> _rules;


    public KniffelScoringService()
    {

        var rules = new List<ScoringRule>
        {
            new CountRule("Einer", 1),
            new CountRule("Zweier", 2),
            new CountRule("Dreier", 3),
            new CountRule("Vierer", 4),
            new CountRule("Fünfer", 5),
            new CountRule("Sechser", 6),

            new ThreeOfAKindRule(),
            new FourOfAKindRule(),
            new FullHouseRule(),
            new SmallStraightRule(),
            new LargeStraightRule(),
            new KniffelRule(),
            new ChanceRule(),
        };

        _rules = rules.ToDictionary(r => r.Name, r => r);
    }


    public int Chance(Wurf wurf)
    {
        return _rules["Chance"].CalculateScore(wurf);
    }

    public int Kniffel(Wurf wurf)
    {
        return _rules["Kniffel"].CalculateScore(wurf);
    }

    public int Einer(Wurf wurf)
    {
        return _rules["Einer"].CalculateScore(wurf);
    }

    public int Zweier(Wurf wurf)
    {
        return _rules["Zweier"].CalculateScore(wurf);
    }

    public int Dreier(Wurf wurf)
    {
        return _rules["Dreier"].CalculateScore(wurf);
    }

    public int Vierer(Wurf wurf)
    {
        return _rules["Vierer"].CalculateScore(wurf);
    }

    public int Fuenfer(Wurf wurf)
    {
        return _rules["Fünfer"].CalculateScore(wurf);
    }

    public int Sechser(Wurf wurf)
    {
        return _rules["Sechser"].CalculateScore(wurf);
    }


    public int Viererpasch(Wurf wurf)
    {
        return _rules["Vierer Pasch"].CalculateScore(wurf);
    }

    public int Dreierpasch(Wurf wurf)
    {
        return _rules["Dreier Pasch"].CalculateScore(wurf);
    }

    public int KleineStrasse(Wurf wurf)
    {
        return _rules["Kleine Strasse"].CalculateScore(wurf);
    }

    public int GrosseStrasse(Wurf wurf)
    {
        return _rules["Grosse Strasse"].CalculateScore(wurf);
    }

    public int FullHouse(Wurf wurf)
    {
        return _rules["Full House"].CalculateScore(wurf);
    }

    public int CalculateScore(Wurf wurf, string rule)
    {
        return _rules[rule].CalculateScore(wurf);
    }

    public IEnumerable<ScoringResult> CalculateScore(Wurf wurf)
    {
        return from rule in _rules.Values
               let result = rule.CalculateScore(wurf)
               where result > 0
               select new ScoringResult(rule.Name, result);
    }
}