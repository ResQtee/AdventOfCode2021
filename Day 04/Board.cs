namespace AdventOfCode2021.Day_4
{
    public class Board
    {
        public Board(int size)
        {
            Fields = new Field[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Fields[i, j] = new Field(0);
                }
            }
        }

        public Field[,] Fields { get; set; }

        internal void Mark(int drawn)
        {
            for (int i = 0; i < Fields.GetLength(0); i++)
            {
                for (int j = 0; j < Fields.GetLength(1); j++)
                {
                    if (Fields[i, j].Value == drawn)
                    {
                        Fields[i, j].Mark = true;
                    }
                }
            }
        }

        internal void Print()
        {
            for (int i = 0; i < Fields.GetLength(0); i++)
            {
                for (int j = 0; j < Fields.GetLength(1); j++)
                {
                    if (Fields[i, j].Mark)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write($"{Fields[i,j].Value.ToString("00")}, ");                    
                }
                Console.Write($"{Environment.NewLine}");
            }
        }
    }
}