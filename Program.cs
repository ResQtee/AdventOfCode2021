// See https://aka.ms/new-console-template for more information
using AdventOfCode2021.Day_1;
using AdventOfCode2021.Day_2;
using AdventOfCode2021.Day_3;
using AdventOfCode2021.Day_4;
using AdventOfCode2021.Day_5;

var originalBgColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Advent of Code 2021");

/*
#region Day 1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{Environment.NewLine}----- Day 1 -----");
Console.ForegroundColor = originalBgColor;
Console.WriteLine($"Answer example part 1: {DepthIncreasementCalculator.CalculateDepthIncreasementsExamplePart1()}");
Console.WriteLine($"Answer part 1: {DepthIncreasementCalculator.CalculateDepthIncreasementsPart1()}");
Console.WriteLine(String.Empty);
Console.WriteLine($"Answer example part 2: {DepthIncreasementCalculator.CalculateDepthIncreasementsExamplePart2()}");
Console.WriteLine($"Answer part 2: {DepthIncreasementCalculator.CalculateDepthIncreasementsPart2()}");
Console.WriteLine(String.Empty);
#endregion

#region Day 2
Console.WriteLine($"{Environment.NewLine}----- Day 2 -----");

var courseCalculationExample = CourseCalculatorPart1.CalculateCourseExample();
Console.WriteLine($"Answer example part 1: Depth:{courseCalculationExample.Depth}, Position:{courseCalculationExample.Position}");
var courseCalculationPart1 = CourseCalculatorPart1.CalculateCourse();
Console.WriteLine($"Answer part 1: Depth:{courseCalculationPart1.Depth}, Position:{courseCalculationPart1.Position} = depth*postion:{courseCalculationPart1.Depth* courseCalculationPart1.Position}");
var courseCalculationExample2 = CourseCalculatorPart2.CalculateCourseExample();
Console.WriteLine($"Answer example part 2: Depth:{courseCalculationExample2.Depth}, Position:{courseCalculationExample2.Position}");
var courseCalculationPart2 = CourseCalculatorPart2.CalculateCourse();
Console.WriteLine($"Answer part 2: Depth:{courseCalculationPart2.Depth}, Position:{courseCalculationPart2.Position} = depth*postion:{courseCalculationPart2.Depth * courseCalculationPart2.Position}");
#endregion

#region Day 3
originalBgColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{Environment.NewLine}----- Day 3 -----");
Console.ForegroundColor = originalBgColor;

new DiagnosticReportDecoderPart1().DecodeExample();
new DiagnosticReportDecoderPart1().DecodePart1();

new DiagnosticReportDecoderPart2().CalculateLifeSupportRatingExample();
new DiagnosticReportDecoderPart2().CalculateLifeSupportRating();
#endregion

#region Fluff
originalBgColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{Environment.NewLine}----- Fluff -----");
Console.ForegroundColor = originalBgColor;

var elfOneNavigator = new NavigatorOne();
var submarineOne = new Submarine(elfOneNavigator);
var destinationSubOne = submarineOne.PlotCourse(CourseInputReader.CoursePart1());
Console.WriteLine($"Submarine 1) Depth: {destinationSubOne.newDepth}, Position: {destinationSubOne.newPosition}, depth*position: {destinationSubOne.newDepth*destinationSubOne.newPosition}");

var elfTwoBetterNavigator = new NavigatorTwo();
var submarineTwo = new Submarine(elfTwoBetterNavigator);
var destinationSubTwo = submarineTwo.PlotCourse(CourseInputReader.CoursePart2());
Console.WriteLine($"Submarine 2) Depth: {destinationSubTwo.newDepth}, Position: {destinationSubTwo.newPosition}, depth*position: {destinationSubTwo.newDepth * destinationSubTwo.newPosition}");

#endregion

#region Day 4
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{Environment.NewLine}----- Day 4 -----");
Console.ForegroundColor = originalBgColor;

BingoInputReader bingoInputReader = new BingoInputReader();

var exampleSquidGame1 = bingoInputReader.Read(@".\Day 4\Input\BingoInputExample1.txt", 5);
exampleSquidGame1.GenerateSoltions();
var exampleBingoBoard = exampleSquidGame1.FirstBingoBoard();
var squidGameExample1Score = exampleSquidGame1.CalculateFinalScore(exampleBingoBoard, exampleSquidGame1.LastDrawn);
Console.WriteLine($"Score: {squidGameExample1Score}");

var exampleSquidGame2 = bingoInputReader.Read(@".\Day 4\Input\BingoInputExample1.txt", 5);
exampleSquidGame2.GenerateSoltions();
var exampleBingoBoard2 = exampleSquidGame2.LastBingoBoard();
var squidGameExample2Score = exampleSquidGame2.CalculateFinalScore(exampleBingoBoard2.Board, exampleBingoBoard2.LastDrawn);
Console.WriteLine($"Score: {squidGameExample2Score}");
Console.WriteLine($"-----");
var firstSquidGame = bingoInputReader.Read(@".\Day 4\Input\BingoInput1.txt", 5);
firstSquidGame.GenerateSoltions();
var firstBingoBoard = firstSquidGame.FirstBingoBoard();
var firstSquidGameScore = firstSquidGame.CalculateFinalScore(firstBingoBoard,firstSquidGame.LastDrawn);
Console.WriteLine($"Score: {firstSquidGameScore }");

var secondSquidGame = bingoInputReader.Read(@".\Day 4\Input\BingoInput1.txt", 5);
secondSquidGame.GenerateSoltions();
(Board board,int last) lastBingoBoard = secondSquidGame.LastBingoBoard();
var secondSquidGameScore = secondSquidGame.CalculateFinalScore(lastBingoBoard.board, lastBingoBoard.last);
Console.WriteLine($"Score: {secondSquidGameScore  }");
#endregion

#region Day 5
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{Environment.NewLine}----- Day 5 -----");
Console.ForegroundColor = originalBgColor;

BruteForceCalculator calculator = new BruteForceCalculator();
var example1 = calculator.CalculateExample();
Console.WriteLine($"Example 1: {example1} overlapping points");

var answer1 = calculator.CalculatePart1();
Console.WriteLine($"Part 1: {answer1} overlapping points");

var example2 = calculator.CalculateExample2();
Console.WriteLine($"Example 2: {example2} overlapping points");

var answer2 = calculator.CalculatePart2();
Console.WriteLine($"Part 2: {answer2} overlapping points");
#endregion
*/
Console.ReadKey();