using System.Drawing;

namespace OptiComposer
{
    /// <summary>
    /// A class to hold the constant variables of the program.
    /// 
    /// Author Jodie Muller
    /// </summary>
    public static class Const
    {
        // Drawing Constants
        // - Sheet
        public static int TopLineX = 30;
        public static int TopLineY = 30;
        public static int SheetWidth = 800;
        public static int LineInterval = 16;
        public static int LineThickness = 2;
        public static int NumberOfLines = 5;
        // - Note
        public static int CleffThickness = 40;
        public static int NoteWidth = 50;
        public static int DotWidth = 20;
        public static int DotLineHeight = 32;

        // Colours
        public static Color BaseColour = Color.Black;
        public static Pen Pen = new Pen(BaseColour, LineThickness);
        public static SolidBrush Brush = new SolidBrush(BaseColour);

        // Note Positions
        public static int MaxTreble = 10; // TODO Change
        public enum Letters { A = 40, B = 32, C = 24, D = 16, E = 8, F = 0, G = -8 };
    }
}
