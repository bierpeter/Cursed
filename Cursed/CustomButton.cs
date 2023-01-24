using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Cursed
{
    internal class CustomButton : Control
    {

        public StringFormat StringForm = new StringFormat();
        public Color ColorFirst { get; set; } = Color.Cyan;
        public Color ColorSecond { get; set; } = Color.RoyalBlue;
        public float GradientRotate { get; set; } = 80F;

        public bool MouseEntered = false;
        public bool MouseClicked = false;

        public int MousetTransp { get; set; } = 30;

        public CustomButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(100, 30);
            StringForm.Alignment = StringAlignment.Center;
            StringForm.LineAlignment = StringAlignment.Center;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush GradPanel = new LinearGradientBrush(ClientRectangle, ColorFirst, ColorSecond, GradientRotate);
            Graphics g = e.Graphics;
            Rectangle rectangle = new Rectangle(0,0, Width-1, Height-1);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawRectangle(new Pen(GradPanel), rectangle);
            g.FillRectangle(GradPanel, rectangle);
            base.OnPaint(e);

            if (MouseEntered)
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(MousetTransp, Color.White)), rectangle);
            }
            
            if (MouseClicked)
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(MousetTransp, Color.Black)), rectangle);
            }

            g.DrawString(Text, Font, new SolidBrush(ForeColor), rectangle, StringForm);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MouseClicked = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MouseClicked = true;
            Invalidate();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }
    }
}
