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
        public static int TopLineX = 30;
        public static int TopLineY = 30;
        public static int SheetWidth = 700;
        public static int LineInterval = 15;
        public static int LineThickness = 2;
        public static int NumberOfLines = 5;

        // Colours
        public static Color BaseColour = Color.Black;
        public static Pen Pen = new Pen(BaseColour);
    }
}
