namespace AdventOfCode2022;

public class Day7
{
    public static int Part1(string[] inputs)
    {
        var fileSystem = new Dictionary<string, int>();
        var currentDirectory = "/";
        fileSystem.Add(currentDirectory, 0);
        foreach (var input in inputs)
        {
            if (input[0].Equals('$'))
            {
                var command = input.Split(' ');
                if (command[1].Equals("cd"))
                {
                    if (command[2].Equals(".."))
                    {
                        var indexOfLastFolder = currentDirectory.LastIndexOf('/');
                        currentDirectory = currentDirectory[..(indexOfLastFolder - 1)];

                    }
                    else
                    {
                        if (command[2].Equals("/")) continue;
                        currentDirectory += command[2] + "/";
                    }
                }
                else if (command[1].Equals("ls"))
                {
                    foreach (var i in fileSystem)
                    {
                        Console.WriteLine($"{i.Key} - {i.Value}");
                    }
                }
            }
            else
            {
                var line = input.Split(' ');
                if (line[0].Equals("dir"))
                {
                    fileSystem.Add(currentDirectory + line[1] + "/", 0);
                }
                else
                {
                    fileSystem.Add(currentDirectory + line[1], int.Parse(line[0]));
                }
            }
        }

        Console.WriteLine("Result");
        foreach (var i in fileSystem)
        {
            Console.WriteLine($"{i.Key} - {i.Value}");
        }
        return -1;
    }
}