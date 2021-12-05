namespace AdventOfCode2021.Day_4
{
    public class SquidGame
    {
        private int drawCounter = -1;

        public List<int> DrawnNumbers { get; set; } = new List<int>();

        public List<Board> Boards { get; set; } = new List<Board>();

        private Dictionary<Board, List<Solution>> solutions = new Dictionary<Board,List<Solution>>();
                       
        public int LastDrawn 
        {
            get 
            { 
                if(drawCounter == -1)
                {
                    return -1; // should be exception.
                }

                return DrawnNumbers[drawCounter]; 
            } 
        }

        public int Draw()
        {
            drawCounter++;
            return DrawnNumbers[drawCounter];
        }

        public void GenerateSoltions()
        {
            solutions = GenerateSolutions();
        }

        public Board FirstBingoBoard()
        {   
            Board? winningBoard = null;

            while (winningBoard == null)
            {
                Mark(Draw());
                winningBoard = FindBingoBoard();
            }
            return winningBoard;
        }        

        public Board FindBingoBoard()
        {
            foreach (var solution in solutions)
            {
                foreach (var boardSolutions in solution.Value)
                {
                    if(boardSolutions.IsBingo)
                    {
                        return solution.Key;
                    }
                }
            }

            return null;
        }

        public (Board Board, int LastDrawn) LastBingoBoard()
        {   
            List<Board>? winningBoards = null;
            Board? lastBoardWon = null;
            int lastDrawn = 0;

            while (drawCounter < DrawnNumbers.Count-1)
            {
                Mark(Draw());
                winningBoards = FindBingoBoards();
                if(winningBoards.Count > 0)
                {
                    foreach(Board board in winningBoards)
                    {
                        lastDrawn = LastDrawn;
                        lastBoardWon = board;

                        solutions.Remove(board);
                    }                    
                }
            }

            return (Board: lastBoardWon, LastDrawn: lastDrawn);
        }

        public List<Board> FindBingoBoards()
        {
            var bingoBoards = new List<Board>();
            foreach (var solution in solutions)
            {
                foreach (var boardSolutions in solution.Value)
                {
                    if (boardSolutions.IsBingo)
                    {
                        bingoBoards.Add(solution.Key);
                    }
                }
            }

            return bingoBoards;
        }

        public int CalculateFinalScore(Board board, int lastDrawn)
        {
            int sumUnmarkedFields = 0;

            for (int i = 0; i < board.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < board.Fields.GetLength(1); j++)
                {
                    if(!board.Fields[i,j].Mark)
                    {
                        sumUnmarkedFields += board.Fields[i, j].Value;
                    }
                }
            }

            Console.WriteLine($"Sum: {sumUnmarkedFields}, last drawn: {lastDrawn}");
            return sumUnmarkedFields * lastDrawn;
        }

        public void Mark(int number)
        {
            foreach (var board in solutions.Keys)
            {
                board.Mark(number);
            }
        }

        private Dictionary<Board, List<Solution>> GenerateSolutions()
        {
            var solutions = new Dictionary<Board, List<Solution>>(Boards.Count);

            foreach (var board in Boards)
            {
                var boardSolutions = new List<Solution>();
                for (int i = 0; i < board.Fields.GetLength(0); i++)
                {
                    var row = new List<Field>();
                    var column = new List<Field>();
                    for (int j = 0; j < board.Fields.GetLength(1); j++)
                    {
                        row.Add(board.Fields[i, j]);
                        column.Add(board.Fields[j, i]);
                    }
                    boardSolutions.Add(new Solution(row));
                    boardSolutions.Add(new Solution(column));
                }
                solutions.Add(board, boardSolutions);
            }
            return solutions;
        }

        private void PrintSolutions()
        {
            foreach (var solution in solutions)
            {
                Console.WriteLine($"----- board -----");
                solution.Key.Print();

                Console.WriteLine($"----- Solutions -----");
                foreach (var boardSolutions in solution.Value)
                {
                    foreach (var field in boardSolutions.Fields)
                    {
                        if (field.Mark)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        Console.Write($"{field.Value.ToString("00")}, ");

                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{Environment.NewLine}");
                }
            }
        }
    }

    public class Solution
    {
        public Solution(List<Field> fields)
        {
            Fields = fields;
        }
        public List<Field> Fields { get; }
        public bool IsBingo
        {
            get { return Fields.All(field => field.Mark); }
        }
    }
}