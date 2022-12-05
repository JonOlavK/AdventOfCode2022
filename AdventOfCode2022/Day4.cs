namespace AdventOfCode2022;

public static class Day4
{
    public static int Part1(string[] inputs)
    {
        var result = 0;
        foreach (var input in inputs)
        {
            var pairs = input.Split(',');
            var first = pairs[0].Split('-');
            var second = pairs[1].Split('-');
            var minFirst = int.Parse(first[0]);
            var maxFirst = int.Parse(first[1]);
            var minSecond = int.Parse(second[0]);
            var maxSecond = int.Parse(second[1]);
            if (minFirst <= minSecond && maxFirst >= maxSecond)
                result++;
            else if (minFirst >= minSecond && maxFirst <= maxSecond)
                result++;
        }

        return result;
    }
}