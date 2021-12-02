// See https://aka.ms/new-console-template for more information
using AdventOfCode2021.Day_1;
using AdventOfCode2021.Day_2;

Console.WriteLine("Advent of Code 2021");
Console.WriteLine(String.Empty);
Console.WriteLine("----- Day 1 -----");
Console.WriteLine($"Answer example part 1: {DepthIncreasementCalculator.CalculateDepthIncreasementsExamplePart1()}");
Console.WriteLine($"Answer part 1: {DepthIncreasementCalculator.CalculateDepthIncreasementsPart1()}");
Console.WriteLine(String.Empty);
Console.WriteLine($"Answer example part 2: {DepthIncreasementCalculator.CalculateDepthIncreasementsExamplePart2()}");
Console.WriteLine($"Answer part 2: {DepthIncreasementCalculator.CalculateDepthIncreasementsPart2()}");
Console.WriteLine(String.Empty);

Console.WriteLine("----- Day 2 -----");

var courseCalculationExample = CourseCalculatorPart1.CalculateCourseExample();
Console.WriteLine($"Answer example part 1: Depth:{courseCalculationExample.Depth}, Position:{courseCalculationExample.Position}");

var courseCalculationPart1 = CourseCalculatorPart1.CalculateCourse();
Console.WriteLine($"Answer part 1: Depth:{courseCalculationPart1.Depth}, Position:{courseCalculationPart1.Position} = depth*postion:{courseCalculationPart1.Depth* courseCalculationPart1.Position}");

var courseCalculationExample2 = CourseCalculatorPart2.CalculateCourseExample();
Console.WriteLine($"Answer example part 2: Depth:{courseCalculationExample2.Depth}, Position:{courseCalculationExample2.Position}");

var courseCalculationPart2 = CourseCalculatorPart2.CalculateCourse();
Console.WriteLine($"Answer part 2: Depth:{courseCalculationPart2.Depth}, Position:{courseCalculationPart2.Position} = depth*postion:{courseCalculationPart2.Depth * courseCalculationPart2.Position}");