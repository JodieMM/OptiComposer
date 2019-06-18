using System;
using System.Drawing;
using System.Windows.Forms;

namespace OptiComposer
{
    /// <summary>
    /// The form for creating sheet music.
    /// </summary>
    public partial class SheetMusic : Form
    {
        /// <summary>
        /// Initialiser for the sheet music form.
        /// </summary>
        public SheetMusic()
        {
            InitializeComponent();
            
            // TODO Draw initial lines
        }



        // ----- I/O -----

        /// <summary>
        /// Moves the highlight based on where the cursor is currently hovering.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawPanel_Hover(object sender, EventArgs e)
        {
            // TODO Check if mouse is over a relevant section
            // If so, move and reshape highlight to that section
        }

        /// <summary>
        /// Reacts to the click of the highlight based on what is highlighted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteHighlight_Click(object sender, EventArgs e)
        {
            // TODO Check if a note has been clicked
            // If so, mark it as selected
            // If not, insert a single-beat note at the selected location
        }
    }
}
