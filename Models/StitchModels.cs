using System.Collections.Generic;

namespace Stitcherina.Models
{
    public class ProjectState
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Tolerance { get; set; }
        public string? ImageBase64 { get; set; }
        public List<(byte R, byte G, byte B)> Palette { get; set; } = new();
        public List<StitchRow> Rows { get; set; } = new();
    }

    public class StitchRow
    {
        public int RowNumber { get; set; }
        public string DirectionLabel { get; set; } = string.Empty;
        public List<ColorSegment> Segments { get; set; } = new();
        public bool IsCompleted { get; set; }
    }

    public class ColorSegment
    {
        public int ColorIndex { get; set; }
        public int Count { get; set; }
        public string HexColor { get; set; } = string.Empty;
        public (byte R, byte G, byte B) Rgb { get; set; }
        public bool IsStitched { get; set; }
    }
}