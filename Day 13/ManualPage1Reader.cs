using System.Drawing;

namespace AdventOfCode2021.Day_13
{
    public class ManualPage1Reader
    {
        public Origami Read(string file)
        {
            var dots = new List<Point>();
            var origami = new Origami();

            using (StreamReader fileStreamReader = new StreamReader(file))
            {
                // Read all dots.
                var line = fileStreamReader.ReadLine();
                while (!string.IsNullOrEmpty(line))
                {
                    
                    var split = line.Trim().Split(',');
                    dots.Add(new Point(int.Parse(split[0]), int.Parse(split[1])));

                    line = fileStreamReader.ReadLine();
                }
                
                // Read all instructions
                while (!fileStreamReader.EndOfStream)
                {
                    line = fileStreamReader.ReadLine();
                    FoldInstruction instruction = new FoldInstruction();
                    var axisIndex = line.IndexOf('=');

                    instruction.Axis = line[axisIndex - 1];
                    instruction.Value = int.Parse(line.Substring(axisIndex + 1));
                    
                    origami.Instructions.Add(instruction);
                }
            }

            origami.Paper = new Paper(dots);
            return origami;
        }
    }
}
