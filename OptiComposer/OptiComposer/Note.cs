namespace OptiComposer
{
    /// <summary>
    /// A class to summarise the requirements of a note.
    /// 
    /// Author Jodie Muller
    /// </summary>
    public class Note
    {
        public int Beats { get; set; }
        public bool Silent { get; set; }
        public string Letter { get; set; }
        public int CLevel { get; set; }

        /// <summary>
        /// Initialiser for a new note.
        /// </summary>
        /// <param name="beats">How long the note lasts</param>
        /// <param name="silent">Whether the note is silent or heard</param>
        /// <param name="letter">The letter representing the pitch</param>
        /// <param name="clevel">How many sets above/below from middle C the note falls</param>
        public Note(int beats = 1, bool silent = false, string letter = "C", int clevel = 0)
        {
            Beats = beats;
            Silent = silent;
            Letter = letter;
            CLevel = clevel;
        }



        // ----- FUNCTIONS -----

        /// <summary>
        /// Draws the note to the page
        /// </summary>
        /// <param name="x">How far on the x plane the note should be drawn</param>
        public void Draw(int x)
        {

        }
    }
}
