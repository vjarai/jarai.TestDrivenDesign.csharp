﻿namespace jarai.tdd8.Kniffel.Legacy;

public class KniffelCalculator
{
    protected int[] dice;

    public KniffelCalculator()
    {
    }

    public KniffelCalculator(int d1, int d2, int d3, int d4, int _5)
    {
        dice = new int[5];
        dice[0] = d1;
        dice[1] = d2;
        dice[2] = d3;
        dice[3] = d4;
        dice[4] = _5;
    }

    public static int Chance(int d1, int d2, int d3, int d4, int d5)
    {
        var total = 0;
        total += d1;
        total += d2;
        total += d3;
        total += d4;
        total += d5;
        return total;
    }

    public static int Kniffel(params int[] dice)
    {
        var counts = new int[6];
        foreach (int die in dice)
        {
            counts[die - 1]++;
        }

        for (var i = 0; i != 6; i++)
        {
            if (counts[i] == 5)
                return 50;
        }

        return 0;
    }


    public static int Ones(int d1, int d2, int d3, int d4, int d5)
    {
        var sum = 0;
        if (d1 == 1) sum++;
        if (d2 == 1) sum++;
        if (d3 == 1) sum++;
        if (d4 == 1) sum++;
        if (d5 == 1)
            sum++;

        return sum;
    }

    public static int Twos(int d1, int d2, int d3, int d4, int d5)
    {
        var sum = 0;
        if (d1 == 2) sum += 2;
        if (d2 == 2) sum += 2;
        if (d3 == 2) sum += 2;
        if (d4 == 2) sum += 2;
        if (d5 == 2) sum += 2;
        return sum;
    }

    public static int Threes(int d1, int d2, int d3, int d4, int d5)
    {
        int s;
        s = 0;
        if (d1 == 3) s += 3;
        if (d2 == 3) s += 3;
        if (d3 == 3) s += 3;
        if (d4 == 3) s += 3;
        if (d5 == 3) s += 3;
        return s;
    }

    public int Fours()
    {
        int sum;
        sum = 0;
        for (var at = 0; at != 5; at++)
        {
            if (dice[at] == 4)
                sum += 4;
        }

        return sum;
    }

    public int Fives()
    {
        var s = 0;
        int i;
        for (i = 0; i < dice.Length; i++)
        {
            if (dice[i] == 5)
                s = s + 5;
        }

        return s;
    }

    public int Sixes()
    {
        var sum = 0;
        for (var at = 0; at < dice.Length; at++)
        {
            if (dice[at] == 6)
                sum = sum + 6;
        }

        return sum;
    }

    public static int FourOfAKind(int _1, int _2, int d3, int d4, int d5)
    {
        int[] tallies;
        tallies = new int[6];
        tallies[_1 - 1]++;
        tallies[_2 - 1]++;
        tallies[d3 - 1]++;
        tallies[d4 - 1]++;
        tallies[d5 - 1]++;
        for (var i = 0; i < 6; i++)
        {
            if (tallies[i] >= 4)
                return (i + 1) * 4;
        }

        return 0;
    }

    public static int ThreeOfAKind(int d1, int d2, int d3, int d4, int d5)
    {
        int[] t;
        t = new int[6];
        t[d1 - 1]++;
        t[d2 - 1]++;
        t[d3 - 1]++;
        t[d4 - 1]++;
        t[d5 - 1]++;
        for (var i = 0; i < 6; i++)
        {
            if (t[i] >= 3)
                return (i + 1) * 3;
        }

        return 0;
    }

    public static int SmallStraight(int d1, int d2, int d3, int d4, int d5)
    {
        int[] tallies;
        tallies = new int[6];
        tallies[d1 - 1] += 1;
        tallies[d2 - 1] += 1;
        tallies[d3 - 1] += 1;
        tallies[d4 - 1] += 1;
        tallies[d5 - 1] += 1;
        if (tallies[0] == 1 &&
            tallies[1] == 1 &&
            tallies[2] == 1 &&
            tallies[3] == 1 &&
            tallies[4] == 1)
            return 15;
        return 0;
    }

    public static int LargeStraight(int d1, int d2, int d3, int d4, int d5)
    {
        int[] tallies;
        tallies = new int[6];
        tallies[d1 - 1] += 1;
        tallies[d2 - 1] += 1;
        tallies[d3 - 1] += 1;
        tallies[d4 - 1] += 1;
        tallies[d5 - 1] += 1;

        if (tallies[1] == 1 &&
            tallies[2] == 1 &&
            tallies[3] == 1 &&
            tallies[4] == 1
            && tallies[5] == 1)
            return 20;
        return 0;
    }

    public static int FullHouse(int d1, int d2, int d3, int d4, int d5)
    {
        int[] tallies;
        var _2 = false;
        int i;
        var _2_at = 0;
        var _3 = false;
        var _3_at = 0;


        tallies = new int[6];
        tallies[d1 - 1] += 1;
        tallies[d2 - 1] += 1;
        tallies[d3 - 1] += 1;
        tallies[d4 - 1] += 1;
        tallies[d5 - 1] += 1;

        for (i = 0; i != 6; i += 1)
        {
            if (tallies[i] == 2)
            {
                _2 = true;
                _2_at = i + 1;
            }
        }

        for (i = 0; i != 6; i += 1)
        {
            if (tallies[i] == 3)
            {
                _3 = true;
                _3_at = i + 1;
            }
        }

        if (_2 && _3)
            return _2_at * 2 + _3_at * 3;
        return 0;
    }
}