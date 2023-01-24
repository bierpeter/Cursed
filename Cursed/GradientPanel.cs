using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Cursed
{
    public class GradientPanel : Panel
    {
        public Color ColorFirst { get; set; } = Color.Black;
        public Color ColorSecond { get; set; } = Color.White;
        public float GradientRotate { get; set; } = 90F;
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush GradPanel = new LinearGradientBrush(ClientRectangle, ColorFirst, ColorSecond, GradientRotate);
            Graphics g = e.Graphics;
            Rectangle rectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawRectangle(new Pen(GradPanel), rectangle);
            g.FillRectangle(GradPanel, rectangle);
            base.OnPaint(e);
        }
    }
}
