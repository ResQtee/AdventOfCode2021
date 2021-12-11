namespace AdventOfCode2021.Day_10
{
    public class ValidationResult
    {
        public ValidationResult(string originalSyntax)
        {
            OriginalSyntax = originalSyntax;
        }

        public ValidationResult(string originalSyntax, int invalidCharIndex)
        {
            OriginalSyntax = originalSyntax;
            FirstInvalidCharIndex = invalidCharIndex;
            IsValid = false;
        }

        public string OriginalSyntax { get; set; }

        public bool IsValid { get; set; } = true;

        public bool IsComplete { get; set; } = true;

        public char? FirstInvalidChar
        {
            get
            {
                if (FirstInvalidCharIndex == -1) return null;

                return OriginalSyntax[FirstInvalidCharIndex];
            }
        }

        public int FirstInvalidCharIndex { get; set; } = -1;
        public char[] IncompleteChars { get; internal set; }
    }
}
