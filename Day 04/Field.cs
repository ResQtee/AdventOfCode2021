namespace AdventOfCode2021.Day_4
{
    public class Field
    {
        public Field(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
        public bool Mark { get; set; } = false;
    }
}