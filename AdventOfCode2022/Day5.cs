namespace AdventOfCode2022;

public static class Day5
{
    public static string Part1(string[] inputs)
    {
        var result = string.Empty;
        var stacks = Array.Empty<Stack<char>>();
        var indexOfMoveList = 0;
        var countStacks = 0;
        for (var i = 0; i < inputs.Length; i++)
        {
            var input = inputs[i];
            if (input[1] == '1')
            {
                countStacks = int.Parse(input[^2].ToString());
                indexOfMoveList = i + 2;
                break;
            }
        }

        stacks = new Stack<char>[countStacks];
        for (var i = 0; i < stacks.Length; i++) stacks[i] = new Stack<char>();

        foreach (var input in inputs)
        {
            var count = 0;
            for (var i = 1; i < input.Length; i += 4)
            {
                if (char.IsUpper(input[i]))
                    stacks[count].Push(input[i]);

                count++;
            }
        }

        for (var index = 0; index < stacks.Length; index++)
        {
            var reversedStack = new Stack<char>();
            while (stacks[index].Count != 0)
            {
                reversedStack.Push(stacks[index].Pop());
            }

            stacks[index] = reversedStack;
        }

        for (int i = indexOfMoveList; i < inputs.Length; i++)
        {
            var moves = inputs[i].Split(' ');
            for (int j = 0; j < int.Parse(moves[1]); j++)
            {
                var from = stacks[int.Parse(moves[3]) - 1].Pop();
                stacks[int.Parse(moves[5]) - 1].Push(from);
            }
        }

        foreach (var stack in stacks)
        {
            result += stack.Pop().ToString();
        }

        return result;
    }

    public static string Part2(string[] inputs)
    {
        var result = string.Empty;
        var stacks = Array.Empty<Stack<char>>();
        var indexOfMoveList = 0;
        var countStacks = 0;
        for (var i = 0; i < inputs.Length; i++)
        {
            var input = inputs[i];
            if (input[1] == '1')
            {
                countStacks = int.Parse(input[^2].ToString());
                indexOfMoveList = i + 2;
                break;
            }
        }

        stacks = new Stack<char>[countStacks];
        for (var i = 0; i < stacks.Length; i++) stacks[i] = new Stack<char>();

        foreach (var input in inputs)
        {
            var count = 0;
            for (var i = 1; i < input.Length; i += 4)
            {
                if (char.IsUpper(input[i]))
                    stacks[count].Push(input[i]);

                count++;
            }
        }

        for (var index = 0; index < stacks.Length; index++)
        {
            var reversedStack = new Stack<char>();
            while (stacks[index].Count != 0)
            {
                reversedStack.Push(stacks[index].Pop());
            }

            stacks[index] = reversedStack;
        }

        for (int i = indexOfMoveList; i < inputs.Length; i++)
        {
            var moves = inputs[i].Split(' ');
            var holderStack = new Stack<char>(int.Parse(moves[1]));
            for (int j = 0; j < int.Parse(moves[1]); j++)
            {
                holderStack.Push(stacks[int.Parse(moves[3]) - 1].Pop());
            }

            for (int j = 0; j < int.Parse(moves[1]); j++)
            {
                stacks[int.Parse(moves[5]) - 1].Push(holderStack.Pop());
            }
        }

        foreach (var stack in stacks)
        {
            result += stack.Pop().ToString();
        }

        return result;
    }
}