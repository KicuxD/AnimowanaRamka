using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AnimowanaRamka
{
    class ButtonShape: Button
    {

        private string btnShape, btnColor, btnText, btnFont;
        private LinearGradientBrush borderBrush;
        private Rectangle borderRectangle;
        private Color cl0 = Color.White, cl1 = Color.White;
        private float ang = 0;
        private int animDirection;
        Timer t = new Timer();

    public ButtonShape()
        {
            DoubleBuffered = true;

            t.Interval = 60;
            t.Enabled = true;

            t.Tick += (s, e) => { Angle = Angle % 360 + animDirection; };

        }

        public float Angle
        {
            get { return ang; }
            set { ang = value; Invalidate(); }
        }

        public string BtnShape
        {
            get { return btnShape; }
            set { btnShape = value; Invalidate(); }
        }

        public string BtnColor
        {
            get { return btnColor; }
            set { btnColor = value; Invalidate(); }
        }

        public string BtnText
        {
            get { return btnText; }
            set { btnText = value; Invalidate(); }
        }

        public string BtnFont
        {
            get { return btnFont; }
            set { btnFont = value; Invalidate(); }
        }

        public int AnimDirection
        {
            get { return animDirection; }
            set { animDirection = value; Invalidate(); }
        }

        public Color CL0
        {
            get { return cl0; }
            set { cl0 = value; Invalidate(); }
        }

        public Color CL1
        {
            get { return cl1; }
            set { cl1 = value; Invalidate(); Invalidate(); }
        }

        public float BorderThickness { get; set; } = 2;

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {

            this.Text = BtnText;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            GraphicsPath grPath = new GraphicsPath();

            switch (btnShape)
            {
                case "Rectangle":
                    Rectangle pathRect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
                    grPath.AddRectangle(pathRect);
                    this.Region = new System.Drawing.Region(grPath);
                    break;
                case "Ellipsis":
                    grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                    this.Region = new System.Drawing.Region(grPath);
                    break;
                case "Circle":
                    grPath.AddEllipse(ClientSize.Width / 3, 0, ClientSize.Width / 3, ClientSize.Height);
                    this.Region = new System.Drawing.Region(grPath);
                    break;
                case "Square":
                    Rectangle pathSquare = new Rectangle(ClientSize.Width/3, 0, ClientSize.Width / 3, ClientSize.Height);
                    grPath.AddRectangle(pathSquare);
                    this.Region = new System.Drawing.Region(grPath);
                    break;
            }

            this.Font = new Font(BtnFont, 12, FontStyle.Regular);


            this.Paint += ButtonShape_Paint;
            base.OnPaint(e);
        }

        private void ButtonShape_Paint(object sender, PaintEventArgs e)
        {

            switch (btnShape)
            {
                case "Rectangle":
                    borderRectangle = new Rectangle(0, 0, Width, Height);
                    borderBrush = new LinearGradientBrush(borderRectangle, cl0, cl1, ang);
                    e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), borderRectangle);
                    break;
                case "Ellipsis":
                    borderRectangle = new Rectangle(0, 0, Width, Height);
                    borderBrush = new LinearGradientBrush(borderRectangle, cl0, cl1, ang);
                    e.Graphics.DrawEllipse(new Pen(borderBrush, BorderThickness), borderRectangle);
                    break;
                case "Circle":
                    borderRectangle = new Rectangle(ClientSize.Width / 3, 0, ClientSize.Width / 3, ClientSize.Height);
                    borderBrush = new LinearGradientBrush(borderRectangle, cl0, cl1, ang);
                    e.Graphics.DrawEllipse(new Pen(borderBrush, BorderThickness), ClientSize.Width / 3, 0, ClientSize.Width / 3, ClientSize.Height);
                    break;
                case "Square":
                    borderRectangle = new Rectangle(ClientSize.Width / 3, 0, ClientSize.Width / 3, ClientSize.Height);
                    borderBrush = new LinearGradientBrush(borderRectangle, cl0, cl1, ang);
                    e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), borderRectangle);
                    break;
            }


        }

    }
}