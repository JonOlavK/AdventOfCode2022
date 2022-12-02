// See https://aka.ms/new-console-template for more information

using AdventOfCode2022;

var inputs = File.ReadAllLines("./Input/day2.txt");
var result = Day2.Part1(inputs);
Console.WriteLine(result);
var test = new[] { "A Y", "B X", "C Z" };
Console.WriteLine(Day2.Part2(test));
result = Day2.Part2(inputs);
Console.WriteLine(result);