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
        private Color cl0 = Color.Yellow, cl1 = Color.Blue;
        private float ang = 45;
        Timer t = new Timer();

    public ButtonShape()
        {
            DoubleBuffered = true;
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

            t.Interval = 60;
            t.Enabled = true;
            t.Tick += (s, e) => { Angle = Angle % 360 + 1; };
            
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
                    Rectangle pathSquare = new Rectangle(ClientSize.Width / 3, 0, ClientSize.Width / 3, ClientSize.Height);
                    grPath.AddRectangle(pathSquare);
                    this.Region = new System.Drawing.Region(grPath);
                    break;
            }

            switch (btnColor)
            {
                case "Black":
                    this.BackColor = Color.Black;
                    break;
                case "Red":
                    this.BackColor = Color.Red;
                    break;
                case "Yellow":
                    this.BackColor = Color.Yellow;
                    break;
                case "Green":
                    this.BackColor = Color.Green;
                    break;
                case "White":
                    this.BackColor = Color.White;
                    break;
                case "Blue":
                    this.BackColor = Color.Blue;
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
                    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                    break;
                case "Circle":
                    borderRectangle = new Rectangle(ClientSize.Width / 3, 0, ClientSize.Width / 3, ClientSize.Height);
                    borderBrush = new LinearGradientBrush(borderRectangle, cl0, cl1, ang);
                    e.Graphics.DrawEllipse(new Pen(borderBrush, BorderThickness), ClientSize.Width / 3, 0, ClientSize.Width / 3, ClientSize.Height);
                    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                    break;
                case "Square":
                    borderRectangle = new Rectangle(ClientSize.Width / 3, 0, ClientSize.Width / 3, ClientSize.Height);
                    borderBrush = new LinearGradientBrush(ClientRectangle, cl0, cl1, ang);
                    GraphicsPath grBorder = new GraphicsPath();
                    grBorder.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
                    grBorder.AddArc(new Rectangle(Width - 20, 0, 20, 20), -90, 90);
                    grBorder.AddArc(new Rectangle(Width - 20, Height - 20, 20, 20), 0, 90);
                    grBorder.AddArc(new Rectangle(0, Height - 20, 20, 20), 90, 90);

                    //e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), ClientRectangle);
                    e.Graphics.FillPath(new LinearGradientBrush(borderRectangle, cl0, cl1, ang), grBorder);
                    break;
            }


        }

    }
}