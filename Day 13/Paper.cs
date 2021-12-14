using System.Drawing;

namespace AdventOfCode2021.Day_13
{
    public class Paper
    {
        public List<Point> Dots { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Paper(List<Point> points)
        {
            Dots = points;
            Width = Dots.MaxBy(p => p.X).X;
            Height = Dots.MaxBy(p => p.Y).Y;
        }       

        public void FoldOverX(int xValue)
        { 
            for (int i = 0; i < Dots.Count; i++)
            {
                if(Dots[i].X > xValue)
                {
                    Dots[i] = new Point(NewValueBasedOnDelta(Dots[i].X, xValue), Dots[i].Y);
                }
            }

            // Remove duplicates.
            Dots.Distinct();

            // Set new width of paper.
            Width = xValue - 1;
        }

        public void FoldOverY(int yValue)
        {
            for (int i = 0; i < Dots.Count; i++)
            {
                if (Dots[i].Y > yValue)
                {
                    Dots[i] = new Point(Dots[i].X, NewValueBasedOnDelta(Dots[i].Y, yValue));
                }
            }

            // Remove duplicates.
            Dots.Distinct();

            // Set new height of paper.
            Height = yValue - 1;
        }

        /// <summary>Calculates the "mirrored" distance will become.</summary>
        private int NewValueBasedOnDelta(int value, int axisValue)
        {
            var delta = value - axisValue;
            return axisValue - delta;
        }

        public void Print()
        {
            for (int i = 0; i <= Height; i++)
            {
                for (int j = 0; j <= Width; j++)
                {
                    if(Dots.Any(p => p.Y ==i && p.X ==j ))
                    {
                        Console.Write($"#");                        
                    }
                    else
                    {
                        Console.Write($".");
                    }
                }
                Console.Write($"{Environment.NewLine}");
            }
            Console.WriteLine();
        }
    }
}
