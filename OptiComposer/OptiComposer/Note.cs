using System.Drawing;

namespace OptiComposer
{
    /// <summary>
    /// A class to summarise the requirements of a note.
    /// 
    /// Author Jodie Muller
    /// </summary>
    public class Note
    {
        public double Beats { get; set; }
        public bool Silent { get; set; }
        public Const.Letters Letter { get; set; }
        public int CLevel { get; set; }
        public Note Next { get; set; } = null;
        public Note Shared { get; set; } = null;
        public string Accent { get; set; } = null;

        /// <summary>
        /// Initialiser for a new note.
        /// </summary>
        /// <param name="beats">How long the note lasts</param>
        /// <param name="silent">Whether the note is silent or heard</param>
        /// <param name="letter">The letter representing the pitch</param>
        /// <param name="clevel">How many sets above/below from middle C the note falls</param>
        public Note(double beats, bool silent, Const.Letters letter, int clevel, Note shared = null, string accent = null)
        {
            Beats = beats;
            Silent = silent;
            Letter = letter;
            CLevel = clevel;
            Shared = shared;
            Accent = accent;
        }



        // ----- FUNCTIONS -----

        /// <summary>
        /// Draws the note to the page
        /// </summary>
        /// <param name="g">Drawing graphics</param>
        /// <param name="x">How far on the x plane the note should be drawn</param>
        public void Draw(Graphics g, int x)
        {
            // TODO Draw Self
            switch (Beats)
            {
                case 1:
                    if (Silent)
                    {

                    }
                    else
                    {
                        int y = (int)Letter + Const.TopLineY;
                        Visuals.DrawDot(g, x, y, true);
                        Visuals.DrawVerticalLine(g, y - Const.DotLineHeight, Const.DotLineHeight, x + Const.DotWidth);
                    }
                    break;
                default:
                    break;
            }

            // Draw Companion Notes
            if (Shared != null)
            {
                Shared.Draw(g, x);
            }
            if (Next != null)
            {
                Next.Draw(g, x + (int)(Const.NoteWidth * Beats));
            }
        }
    }
}
