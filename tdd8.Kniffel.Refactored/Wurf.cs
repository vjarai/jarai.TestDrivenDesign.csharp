using System.Collections;

namespace jarai.tdd8.KniffelRefactored;

public class Wurf : IEnumerable<int>
{
    private readonly int[] _wuerfel = new int[5];

    public Wurf()
    {
        var random = new Random();

        for (var i = 0; i < _wuerfel.Length; i++)
        {
            _wuerfel[i] = random.Next(1, 7);
        }

        _wuerfel = _wuerfel.OrderBy(d => d).ToArray();
    }

    public int[] GetCounts()
    {
        int[] counts = new int[6];

        foreach (int die in _wuerfel)
        {
            counts[die - 1]++;
        }

        return counts;
    }

    public Wurf(params int[] wuerfel)
    {
        if (wuerfel.Length != 5)
            throw new ArgumentException("A Wurf must contain exactly 5 numbers.");

        _wuerfel = wuerfel;
    }


    public IEnumerator<int> GetEnumerator()
    {
        return _wuerfel.AsEnumerable().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _wuerfel.GetEnumerator();
    }
}