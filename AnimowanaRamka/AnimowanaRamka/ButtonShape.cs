using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Windows.Media;

namespace AnimowanaRamka
{
    class ButtonShape: Button
    {

        private string btnShape, btnColor, btnText, btnFont;
        private Brush borderBrush;
        private Rectangle borderRectangle;
        Color cl0 = Color.Yellow, cl1 = Color.Blue;
        Timer t = new Timer();
        private float ang;

        public ButtonShape()
        {
            DoubleBuffered = true;
            t.Interval = 60;
            t.Start();
            t.Tick += (s, e) => { Angle = Angle % 360 + 1; };
        }

        public string BtnShape
        {
            get { return btnShape; }
            set { btnShape = value; }
        }

        public string BtnColor
        {
            get { return btnColor; }
            set { btnColor = value; }
        }

        public string BtnText
        {
            get { return btnText; }
            set { btnText = value; }
        }

        public string BtnFont
        {
            get { return btnFont; }
            set { btnFont = value; }
        }

        public float BorderThickness { get; set; } = 242342534;

        public float Angle
        {
            get { return ang; }
            set { ang = value; Invalidate(); }
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {

            this.Text = BtnText;

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
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
