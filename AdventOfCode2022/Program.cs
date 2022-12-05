﻿// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using AdventOfCode2022;

var inputs = File.ReadAllLines("./Input/day2.txt");
var result = Day2.Part1(inputs);
Console.WriteLine($"Day 2 Part 1 {result}");
result = Day2.Part2(inputs);
Console.WriteLine($"Day 2 Part 2 {result}");

var testInputs = File.ReadAllLines("./Input/day3test.txt");
result = Day3.Part1(testInputs);
Console.WriteLine($"Day 3 Part 1 Test Results: {result}");
inputs = File.ReadAllLines("./Input/day3.txt");
result = Day3.Part1(inputs);
Console.WriteLine($"Day 3 Part 1 {result}");
result = Day3.Part2(testInputs);
Console.WriteLine($"Day 3 Part 2 Test Results: {result}");
result = Day3.Part2(inputs);
Console.WriteLine($"Day 3 Part 2 {result}");

testInputs = File.ReadAllLines("./Input/day4test.txt");
result = Day4.Part1(testInputs);
Console.WriteLine($"Day 4 Part 1 Test Results: {result}");
inputs = File.ReadAllLines("./Input/day4.txt");
result = Day4.Part1(inputs);
Console.WriteLine($"Day 4 Part 1 {result}");