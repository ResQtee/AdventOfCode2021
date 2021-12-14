// See https://aka.ms/new-console-template for more information
using AdventOfCode2021.Day_1;
using AdventOfCode2021.Day_10;
using AdventOfCode2021.Day_11;
using AdventOfCode2021.Day_12;
using AdventOfCode2021.Day_13;
using AdventOfCode2021.Day_2;
using AdventOfCode2021.Day_3;
using AdventOfCode2021.Day_4;
using AdventOfCode2021.Day_5;
using AdventOfCode2021.Day_6;
using AdventOfCode2021.Day_7;
using AdventOfCode2021.Day_8;
using AdventOfCode2021.Day_9;

var originalBgColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Advent of Code 2021");

#region previous
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

#region Day 6
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{Environment.NewLine}----- Day 6 -----");
Console.ForegroundColor = originalBgColor;


var initialExampleState = new List<int> { 3, 4, 3, 1, 2 };
var pInitialExampleState = new List<int> { 3, 4, 3, 1, 2 };
var pState1 = new List<int> { 5, 3, 2, 2, 1, 1, 4, 1, 5, 5, 1, 3, 1, 5, 1, 2, 1, 4, 1, 2, 1, 2, 1, 4, 2, 4, 1, 5, 1, 3, 5, 4, 3, 3, 1, 4, 1, 3, 4, 4, 1, 5, 4, 3, 3, 2, 5, 1, 1, 3, 1, 4, 3, 2, 2, 3, 1, 3, 1, 3, 1, 5, 3, 5, 1, 3, 1, 4, 2, 1, 4, 1, 5, 5, 5, 2, 4, 2, 1, 4, 1, 3, 5, 5, 1, 4, 1, 1, 4, 2, 2, 1, 3, 1, 1, 1, 1, 3, 4, 1, 4, 1, 1, 1, 4, 4, 4, 1, 3, 1, 3, 4, 1, 4, 1, 2, 2, 2, 5, 4, 1, 3, 1, 2, 1, 4, 1, 4, 5, 2, 4, 5, 4, 1, 2, 1, 4, 2, 2, 2, 1, 3, 5, 2, 5, 1, 1, 4, 5, 4, 3, 2, 4, 1, 5, 2, 2, 5, 1, 4, 1, 5, 1, 3, 5, 1, 2, 1, 1, 1, 5, 4, 4, 5, 1, 1, 1, 4, 1, 3, 3, 5, 5, 1, 5, 2, 1, 1, 3, 1, 1, 3, 2, 3, 4, 4, 1, 5, 5, 3, 2, 1, 1, 1, 4, 3, 1, 3, 3, 1, 1, 2, 2, 1, 2, 2, 2, 1, 1, 5, 1, 2, 2, 5, 2, 4, 1, 1, 2, 4, 1, 2, 3, 4, 1, 2, 1, 2, 4, 2, 1, 1, 5, 3, 1, 4, 4, 4, 1, 5, 2, 3, 4, 4, 1, 5, 1, 2, 2, 4, 1, 1, 2, 1, 1, 1, 1, 5, 1, 3, 3, 1, 1, 1, 1, 4, 1, 2, 2, 5, 1, 2, 1, 3, 4, 1, 3, 4, 3, 3, 1, 1, 5, 5, 5, 2, 4, 3, 1, 4 };

ParallelLanternfishSpawnModel pModelExample = new ParallelLanternfishSpawnModel(pInitialExampleState);
ParallelLanternfishSpawnModel pModelPart1 = new ParallelLanternfishSpawnModel(pState1);

GroupedLanternfishModel groupedModel = new GroupedLanternfishModel();
groupedModel.ForwardXDays(256, pState1);
#endregion

#region Day 7
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{Environment.NewLine}----- Day 7 -----");
Console.ForegroundColor = originalBgColor;


var initialExampleStateD7 = new List<int> { 16, 1, 2, 0, 4, 2, 7, 1, 2, 14 };
var sas = new SubmarineAlignmentSystem();

var strategy = sas.CalculateBestAlignment(initialExampleStateD7, 0, 10);
Console.WriteLine($"Example) Cheapest level: {strategy.Level} - fuel cost: {strategy.FuelCost}");

var crabPositions1 = CrabPositionsReader.ReadCrabPositions(@".\Day 7\Input\crabPositions.txt");
var strategy1 = sas.CalculateBestAlignment(crabPositions1, 0, 2000);
Console.WriteLine($"Part 1) Cheapest level: {strategy1.Level} - fuel cost: {strategy1.FuelCost}");

var sasP2 = new SubmarineAlignmentSystemPart2();
var strategy2 = sasP2.CalculateBestAlignment(crabPositions1, 0, 2000);
Console.WriteLine($"Part 2) Cheapest level: {strategy2.Level} - fuel cost: {strategy2.FuelCost}");

#endregion
#region Day 8
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{Environment.NewLine}----- Day 8 -----");
Console.ForegroundColor = originalBgColor;

SignalPatternReader reader = new SignalPatternReader();
var signalDecoder = new SignalDecoder();

var exampleSignals = reader.ReadSignalPatterns(@".\Day 8\Input\ExampleSignalPatterns.txt");
signalDecoder.Decode(exampleSignals[0]);

var examplePart1Signals = reader.ReadSignalPatterns(@".\Day 8\Input\ExamplePart1SignalPatterns.txt");
var examplePart1Answer = signalDecoder.Count1478(examplePart1Signals);
Console.WriteLine($"Total is: {examplePart1Answer}");

var part1Signals = reader.ReadSignalPatterns(@".\Day 8\Input\Part1SignalPatterns.txt");
var answer1 = signalDecoder.Count1478(part1Signals);
Console.WriteLine($"Total is: {answer1}");

#endregion
#region Day 9
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{Environment.NewLine}----- Day 9 -----");
Console.ForegroundColor = originalBgColor;

var heightMapReader = new HeightMapReader();

var exampleHeightMap = heightMapReader.Read(@".\Day 09\Input\ExampleHeightMap.txt");
var exampleLowPoints = exampleHeightMap.FindLowPoints();
var exampleRiskLevel = exampleHeightMap.CalculateRiskLevelSum(exampleLowPoints);
Console.WriteLine($"Risk level: {exampleRiskLevel}");
var examapleBasinSizes = exampleHeightMap.CalculateAllBasinSize(exampleLowPoints);
var exampleTop3 = exampleHeightMap.Find3LargestBasin(examapleBasinSizes);
long exampleScore = exampleTop3.Aggregate( (s, x) => s*x);
Console.WriteLine($"Score: {exampleScore}");

Console.WriteLine($"Part 1");
var heightMap1 = heightMapReader.Read(@".\Day 09\Input\HeightMap1.txt");
var lowPoints1 = heightMap1.FindLowPoints();
var riskLevel1 = heightMap1.CalculateRiskLevelSum(lowPoints1);
Console.WriteLine($"Risk level: {riskLevel1}");

var basinSizes1 = heightMap1.CalculateAllBasinSize(lowPoints1);
var threeLargest1 = heightMap1.Find3LargestBasin(basinSizes1);
var score1 = threeLargest1.Aggregate( (s, x) => s* x);
Console.WriteLine($"Score: {score1}");
#endregion
#region Day 10
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{Environment.NewLine}----- Day 10 -----");
Console.ForegroundColor = originalBgColor;
SyntaxScoring syntaxScoring = new SyntaxScoring();
AutoComplete autoComplete = new AutoComplete();

var results = syntaxScoring.ValidateChunkReport(File.ReadAllLines(@".\Day 10\Input\Example.txt"));
var totalScore = syntaxScoring.TotalScore(results);
foreach (var result in results)
{
    if (result.IsValid)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }

    Console.WriteLine(result.OriginalSyntax);
}
Console.ResetColor();
Console.WriteLine();
Console.WriteLine($"Total score is: {totalScore}");
var autoCompleteScore = autoComplete.MiddleScore(results.Where(r => !r.IsComplete).ToList());
Console.WriteLine($"Autocomplete score is: {autoCompleteScore}");

Console.WriteLine();

var part1ValidationResults = syntaxScoring.ValidateChunkReport(File.ReadAllLines(@".\Day 10\Input\Part1.txt"));
var part1TotalScore = syntaxScoring.TotalScore(part1ValidationResults);
Console.WriteLine($"Part 1 total score is: {part1TotalScore}");

var part1AutoCompleteScore = autoComplete.MiddleScore(part1ValidationResults.Where(r => !r.IsComplete).ToList());
Console.WriteLine($"Part 1 autocomplete score is: {part1AutoCompleteScore}");
#endregion

#region Day 11
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{Environment.NewLine}----- Day 11 -----");
Console.ForegroundColor = originalBgColor;

var exampleFile = new[]
{
    "5483143223",
    "2745854711",
    "5264556173",
    "6141336146",
    "6357385478",
    "4167524645",
    "2176841721",
    "6882881134",
    "4846848554",
    "5283751526"
};

var delr = new DumboEnergyLevelReader();
var exampleMap = delr.CreateDumboOctopusMap(exampleFile);

DumboSimulator sim = new DumboSimulator();
//sim.Simulate(exampleMap, 100);
Console.WriteLine($"Steps: {sim.SynchronizedFlashCounter(exampleMap)}");

var dumboMap = delr.Read(@".\Day 11\Input\DumboEnergyLevels.txt");
//sim.Simulate(dumboMap, 100);
Console.WriteLine($"Steps: {sim.SynchronizedFlashCounter(dumboMap)}");
#endregion


#region Day 12
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{Environment.NewLine}----- Day 12 -----");
Console.ForegroundColor = originalBgColor;

var caveMapReader = new CaveMapReader();

var example1Caves = new[] {"start-A","start-b","A-c","A-b","b-d","A-end","b-end"};
var example2Caves = new[] {"dc-end","HN-start","start-kj","dc-start","dc-HN","LN-dc","HN-end","kj-sa","kj-HN","kj-dc",};
var example3Caves = new[] {"fs-end","he-DX","fs-he","start-DX","pj-DX","end-zg","zg-sl","zg-pj","pj-he",
                            "RW-he","fs-DX","pj-RW","zg-RW","start-pj","he-WI","zg-he","pj-fs","start-RW",
                          };

var example1Map = caveMapReader.ReadCaves(example1Caves);
var example1Paths = caveMapReader.CountAllStartToEndPaths(example1Map);
Console.WriteLine($"No of paths to end: {example1Paths}");
var example1Paths2 = caveMapReader.CountAllStartToEndPathsPart2(example1Map);
Console.WriteLine($"No of paths to end: {example1Paths2}");

var example2Map = caveMapReader.ReadCaves(example2Caves);
var example2Paths = caveMapReader.CountAllStartToEndPaths(example2Map);
Console.WriteLine($"No of paths to end: {example2Paths}");
var example2Paths2 = caveMapReader.CountAllStartToEndPathsPart2(example2Map);
Console.WriteLine($"No of paths to end: {example2Paths2}");

var example3Map = caveMapReader.ReadCaves(example3Caves);
var example3Paths = caveMapReader.CountAllStartToEndPaths(example3Map);
Console.WriteLine($"No of paths to end: {example3Paths}");
var example3Paths2 = caveMapReader.CountAllStartToEndPathsPart2(example3Map);
Console.WriteLine($"No of paths to end: {example3Paths2}");

var part1CaveMap = caveMapReader.ReadCavesFromFile(@".\Day 12\Input\Caves.txt");
var part1Paths = caveMapReader.CountAllStartToEndPaths(part1CaveMap);
Console.WriteLine($"No of paths to end: {part1Paths}");
var part2Paths = caveMapReader.CountAllStartToEndPathsPart2(part1CaveMap);
Console.WriteLine($"No of paths to end: {part2Paths}");
*/
#endregion

#region Day 13
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{Environment.NewLine}----- Day 13 -----");
Console.ForegroundColor = originalBgColor;

ManualPage1Reader manualPage1Reader = new ManualPage1Reader();

var exampleOrigami = manualPage1Reader.Read(@".\Day 13\Input\ExamplePage.txt");
exampleOrigami.ExecuteInstructions();

var origami = manualPage1Reader.Read(@".\Day 13\Input\ManualPage1.txt");
origami.ExecuteInstructions();

#endregion
Console.ReadKey();