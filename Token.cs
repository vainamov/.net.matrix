namespace dotNetdotMatrix
{
    public class Token
    {
        public string Content { get; set; }
        public bool Inverted { get; set; }
        public Align Orientation { get; set; }
        public bool DoLoop { get; set; }
        public int Duration { get; set; }
        public int Index { get; set; }
        public int Line { get; set; }
        public bool Keep { get; set; }
        public string Color { get; set; }

        public Token(string content, bool inverted, Align orientation, bool doLoop, int duration, int index, int line = 0, bool keep = false, string color = "#E8AA0E") {
            Content = content;
            Inverted = inverted;
            Orientation = orientation;
            DoLoop = doLoop;
            Duration = duration;
            Index = index;
            Line = line;
            Keep = keep;
            Color = color;
        }
    }

    public enum Align
    {
        Middle,
        Left,
        Right,
        Flow,
        FlowMiddle
    }
}
