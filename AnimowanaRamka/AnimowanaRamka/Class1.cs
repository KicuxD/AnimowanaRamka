using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace AnimowanaRamka
{
    [DefaultEvent("Click")]
    class Class1 : UserControl
    {
        int wh = 20;
        float ang = 45;
        Color cl0 = Color.Red, cl1 = Color.Orange;
        Timer t = new Timer();

        public Class1()
        {
            DoubleBuffered = true;

            t.Interval = 60;
            t.Start();
            t.Tick += (s, e) => { ang = ang % 360 + 1; };
        }

        public float Angle
        {
            get { return ang; }
            set { ang = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get { return wh; }
            set { wh = value; Invalidate(); }
        }

        public Color Color0
        {
            get { return cl0; }
            set { cl0 = value; Invalidate(); }
        }

        public Color Color1
        {
            get { return cl1; }
            set { cl1 = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath gr = new GraphicsPath();

            gr.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gr.AddArc(new Rectangle(Width - wh, 0, wh, wh), -90, 90);
            gr.AddArc(new Rectangle(Width - wh, Height - wh, wh, wh), 0, 90);
            gr.AddArc(new Rectangle(0, Height - wh, wh, wh), 90, 90);

            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, cl0, cl1, ang), gr);

            base.OnPaint(e);
        }
    }
}
