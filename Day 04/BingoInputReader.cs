using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_4
{
    public class BingoInputReader
    {
        public SquidGame Read(string file, int boardSize)
        {
            var game = new SquidGame();

            using (StreamReader fileStreamReader = new StreamReader(file))
            {
                // First line is the numbers that are drawn.
                game.DrawnNumbers.AddRange(ReadNumbers(fileStreamReader));

                // Read cards(x lines) until end of file                
                while (!fileStreamReader.EndOfStream)
                {
                    var line = fileStreamReader.ReadLine();
                    if (string.IsNullOrEmpty(line)) // start of a new board.
                    {
                        game.Boards.Add(ReadBoard(fileStreamReader, boardSize));
                    }                    
                }
            }

            return game;
        }

        private List<int> ReadNumbers(StreamReader streamReader)
        {
            return streamReader.ReadLine().Trim().Split(',').Select(ns => int.Parse(ns)).ToList();
        }

        private Board ReadBoard(StreamReader streamReader, int boardSize)
        {
            Board board = new Board(boardSize);

            for (int rowIndex = 0; rowIndex < boardSize; rowIndex++)
            {
                var line = streamReader.ReadLine();
                var numberStrings = line.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var numbers = numberStrings.Select(ns => int.Parse(ns)).ToArray();

                for (int columnIndex = 0; columnIndex < numbers.Length; columnIndex++)
                {
                    board.Fields[rowIndex, columnIndex].Value = numbers[columnIndex];
                }
            }
            return board;
        }        
    }
}