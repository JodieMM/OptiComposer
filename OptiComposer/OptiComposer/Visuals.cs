using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OptiComposer
{
    /// <summary>
    /// Class to draw the different components.
    /// 
    /// Author Jodie Muller
    /// </summary>
    public static class Visuals
    {
        /// <summary>
        /// Draws a straight vertical line.
        /// </summary>
        /// <param name="g">Graphics to draw to</param>
        /// <param name="startY">Start position on y plane</param>
        /// <param name="endY">End position on y plane</param>
        /// <param name="x">Constant x position</param>
        public static void DrawVerticalLine(Graphics g, int startY, int endY, int x)
        {
            g.DrawLine(Const.Pen, x, startY, x, endY);
        }

        /// <summary>
        /// Draws the blank sheet outline for notes to be added to.
        /// </summary>
        /// <param name="g"></param>
        public static void DrawBlankSheet(Graphics g)
        {
            // Draw Outer Box
            g.DrawRectangle(Const.Pen, Const.TopLineX, Const.TopLineY, Const.SheetWidth, Const.LineInterval * (Const.NumberOfLines - 1));
            for (int i = 1; i < Const.NumberOfLines - 1; i++)
            {
                g.DrawLine(Const.Pen, Const.TopLineX, Const.TopLineY + i * Const.LineInterval, Const.TopLineX + Const.SheetWidth, Const.TopLineY + i * Const.LineInterval);
            }            
        }
    }
}
