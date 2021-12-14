using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_13
{
    public class Origami
    {
        public Paper? Paper { get; set; }
        public List<FoldInstruction> Instructions { get; set; } = new List<FoldInstruction>();

        public void ExecuteInstructions()
        {
            if (Paper == null) return;

            foreach (var instruction in Instructions)
            {
                if (instruction.Axis == 'x')
                {
                    Paper.FoldOverX(instruction.Value);
                }

                if (instruction.Axis == 'y')
                {
                    Paper.FoldOverY(instruction.Value);
                }
            }

            Paper.Print();
        }
    }
}
