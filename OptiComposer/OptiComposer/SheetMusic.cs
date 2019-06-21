using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OptiComposer
{
    /// <summary>
    /// The form for creating sheet music.
    /// 
    /// Author Jodie Muller
    /// </summary>
    public partial class SheetMusic : Form
    {
        public List<Note> Song = new List<Note>();
        public Graphics Graphics;
        public Bitmap DrawArea;


        /// <summary>
        /// Initialiser for the sheet music form.
        /// </summary>
        public SheetMusic()
        {
            InitializeComponent();

            DrawArea = new Bitmap(DrawPanel.Size.Width, DrawPanel.Size.Height);
            DrawPanel.Image = DrawArea;
            Graphics = Graphics.FromImage(DrawArea);
            Visuals.DrawBlankSheet(Graphics);

            // DEMO PRACTICING
            Song.Add(new Note(1, false, Const.Letters.C, 0));
            Song.Add(new Note(1, false, Const.Letters.B, 0));
            Render();
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

        public void Render()
        {
            Visuals.DrawBlankSheet(Graphics);
            for (int i = 0; i < Song.Count; i++)
            {
                Song[i].Draw(Graphics, i*Const.NoteWidth + Const.TopLineX + Const.CleffThickness + Const.DotWidth);
            }
        }
    }
}
