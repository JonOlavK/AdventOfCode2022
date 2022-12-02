namespace AdventOfCode2022;

public class Day2
{
    public static int Part1(string[] inputs)
    {
        var result = 0;
        foreach (var input in inputs)
        {
            var characters = input.Split(' ');
            var points = GetResult(characters[1], characters[0]);
            points += GetNumberRepresentation(characters[1]);
            result += points;
        }

        return result;
    }

    private static int GetResult(string player, string opponent)
    {
        var playerNumber = GetNumberRepresentation(player);
        var opponentNumber = GetNumberRepresentation(opponent);
        if (playerNumber == opponentNumber)
            return 3;
        if (playerNumber - opponentNumber == 1 || playerNumber - opponentNumber == -2)
            return 6;
        return 0;
    }

    private static int GetNumberRepresentation(string input)
    {
        return input switch
        {
            "A" => 1,
            "X" => 1,
            "B" => 2,
            "Y" => 2,
            "C" => 3,
            "Z" => 3,
            _ => throw new InvalidOperationException()
        };
    }
}