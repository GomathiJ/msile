// -----------------------------------------------------------------------
// <copyright file="SkinnableSplitContainer.cs" company="Camilo Martin">
//     Licensed under the GNU GPL v3. 
// </copyright>
// -----------------------------------------------------------------------

namespace Msile
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// A skinnable version of the SplitContainer.
    /// </summary>
    public class SkinnableSplitContainer : SplitContainer
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            e = Helpers.ThrowExceptionIfNull(e);

            Graphics g = e.Graphics;

            // Just to show that it works.
            g.FillRegion(Brushes.Blue, new Region(this.getSplitterBodyRectangle()));
            g.FillRegion(Brushes.Red, new Region(this.getSplitterHeadRectangle()));
            g.FillRegion(Brushes.Lime, new Region(this.getSplitterTailRectangle()));
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            // This method is intentionally blank to cancel the default behavior.
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            e = Helpers.ThrowExceptionIfNull(e);

            // Only events with the left button matters to us.
            if (e.Button.Equals(MouseButtons.Left))
            {
                if (this.Orientation.Equals(Orientation.Vertical))
                {
                    // Only move the splitter if the mouse is within the appropriate bounds.
                    if (e.X > 0 && e.X < this.Width)
                    {
                        this.SplitterDistance = e.X;
                    }
                }
                else
                {
                    // Only move the splitter if the mouse is within the appropriate bounds
                    if (e.Y > 0 && e.Y < this.Height)
                    {
                        this.SplitterDistance = e.Y;
                    }
                }
            }
        }

        private Rectangle getSplitterHeadRectangle()
        {
            Rectangle result = SplitterRectangle;
            if (this.Orientation == Orientation.Horizontal)
            {
                result.Width = result.Height;
            }
            else
            {
                result.Height = result.Width;
            }
            return result;
        }

        private Rectangle getSplitterBodyRectangle()
        {
            Rectangle result = SplitterRectangle;
            if (this.Orientation == Orientation.Horizontal)
            {
                result.X = result.Height;
                result.Width -= result.Height * 2;
            }
            else
            {
                result.Y = result.Width;
                result.Height -= result.Width * 2;
            }
            return result;
        }

        private Rectangle getSplitterTailRectangle()
        {
            Rectangle result = SplitterRectangle;
            if (this.Orientation == Orientation.Horizontal)
            {
                result.X = result.Width - result.Height;
                result.Width = result.Height;
            }
            else
            {
                result.Y = result.Height - result.Width;
                result.Height = result.Width;
            }
            return result;
        }
    }
}
