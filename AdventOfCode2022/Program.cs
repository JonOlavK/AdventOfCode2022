// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using AdventOfCode2022;

var inputs = File.ReadAllLines("./Input/day2.txt");
var result = Day2.Part1(inputs);
Console.WriteLine($"Day 2 Part 1 {result}");
result = Day2.Part2(inputs);
Console.WriteLine($"Day 2 Part 2 {result}");