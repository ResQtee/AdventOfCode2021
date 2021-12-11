namespace AdventOfCode2021.Day_10
{
    public class AutoComplete
    {
        private ChunkSyntax chunkSyntax = new ChunkSyntax();

        private Dictionary<char, int> scoringTable = new Dictionary<char, int>
    {
        {')',1 },
        {']',2 },
        {'}',3 },
        {'>',4 }
    };

        public long MiddleScore(List<ValidationResult> validationResults)
        {
            var scores = validationResults.Select(x => Score(x)).OrderBy(s => s).ToList();
            var middleIndex = (scores.Count() - 1) / 2;

            return scores[middleIndex];
        }

        private long Score(ValidationResult validationResult)
        {
            var incompleteChars = validationResult.IncompleteChars;
            long totalScore = 0;

            foreach (var c in incompleteChars)
            {
                totalScore = totalScore * 5;
                totalScore = totalScore + scoringTable[(char)chunkSyntax.MatchingCloseChar(c)];
            }

            return totalScore;
        }
    }
}
