namespace AdventOfCode2022;

public static class Day3
{
    public static char[] priorities = new[]
    {
        ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
        'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
        'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
    };

    public static int Part1(string[] inputs)
    {
        var result = 0;
        foreach (var input in inputs)
        {
            var firstHalf = input[..(input.Length / 2)];
            var secondHalf = input.Substring(input.Length / 2, input.Length / 2);
            var commonLetter = firstHalf.Intersect(secondHalf);
            result += Array.IndexOf(priorities, commonLetter.First());
        }

        return result;
    }

    public static int Part2(string[] inputs)
    {
        var result = 0;
        for (var i = 0; i < inputs.Length / 3; i++)
        {
            var first = inputs[i * 3];
            var second = inputs[i * 3 + 1];
            var third = inputs[i * 3 + 2];
            var recurringLetter = first.Intersect(second).Intersect(third);
            result += Array.IndexOf(priorities, recurringLetter.First());
        }

        return result;
    }
}