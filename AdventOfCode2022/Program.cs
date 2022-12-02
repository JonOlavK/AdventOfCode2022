// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using AdventOfCode2022;

Console.WriteLine("Hello, World!");
var inputs = File.ReadAllLines("./Input/day2.txt");
var result = Day2.Part1(inputs);
Debugger.Break();