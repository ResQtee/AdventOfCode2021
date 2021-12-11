using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day_10
{
    public class ChunkSyntax
    {
        private Dictionary<char, char> ValidChunkSyntax = new Dictionary<char, char>
        {
            {'(', ')'}, {'[', ']'}, {'{', '}'}, {'<', '>'}
        };

        public char[] ValidOpenChars
        {
            get { return ValidChunkSyntax.Keys.ToArray(); }
        }

        public bool IsValidOpen(char open)
        {
            return ValidOpenChars.Contains(open);
        }

        public bool IsValidClose(char open, char close)
        {
            return ValidOpenChars.Contains(open) && ValidChunkSyntax[open] == close;
        }

        public char? MatchingCloseChar(char open)
        {
            if (ValidOpenChars.Contains(open))
            {
                return ValidChunkSyntax[open];
            }

            return null;
        }
    }
}
