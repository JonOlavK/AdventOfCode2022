namespace AdventOfCode2022;

public static class Day6
{
    public static int Part1(string[] inputs)
    {
        for (int i = 0; i < inputs[0].Length; i++)
        {
            if (i > 3)
            {
                var lastFour = inputs[0].Substring(i - 4, 4);
                if (lastFour.Distinct().Count() == 4)
                {
                    return i;
                }
            }
        }

        return -1;
    }

    public static int Part2(string[] inputs)
    {
        for (int i = 0; i < inputs[0].Length; i++)
        {
            if (i > 13)
            {
                var lastFour = inputs[0].Substring(i - 14, 14);
                if (lastFour.Distinct().Count() == 14)
                {
                    return i;
                }
            }
        }

        return -1;
    }
}