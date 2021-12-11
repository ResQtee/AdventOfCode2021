namespace AdventOfCode2021.Day_10
{
    public class SyntaxScoring
    {
        private ChunkSyntax chunkSyntax = new ChunkSyntax();

        public List<ValidationResult> ValidateChunkReport(string[] lines)
        {
            return lines.Select(lines => ValidateSyntax(lines)).ToList();//.Where(result => !result.IsValid).ToList();        
        }

        public ValidationResult ValidateSyntax(string line)
        {
            Stack<char> stack = new Stack<char>();
            var lineCharacters = line.ToCharArray();

            for (int i = 0; i < lineCharacters.Length; i++)
            {
                if (IsOpenChunk(lineCharacters[i]))
                {
                    stack.Push(lineCharacters[i]);
                    continue;
                }

                if (IsMatchingClosedChunk(stack.Peek(), lineCharacters[i]))
                {
                    stack.Pop();
                    continue;
                }

                // Invalid syntax on line
                return new ValidationResult(line, i);
            }

            var validationResult = new ValidationResult(line);

            if (stack.Count > 0)
            {
                validationResult.IsComplete = false;
                validationResult.IncompleteChars = stack.ToArray();

            }

            return validationResult;
        }

        private Dictionary<char, int> scoringTable = new Dictionary<char, int>
    {
        {')',3 },
        {']',57 },
        {'}',1197 },
        {'>',25137 }
    };

        public int TotalScore(List<ValidationResult> validationResults)
        {
            return validationResults.Sum(validationResult => Score(validationResult));
        }

        public int Score(ValidationResult? validationResult)
        {
            if (validationResult == null || validationResult.IsValid) return 0;

            return scoringTable[(char)validationResult.FirstInvalidChar];
        }

        private bool IsMatchingClosedChunk(char openChar, char closeChar)
        {
            return chunkSyntax.IsValidClose(openChar, closeChar);
        }

        private bool IsOpenChunk(char openChar)
        {
            return chunkSyntax.IsValidOpen(openChar);
        }
    }
}
