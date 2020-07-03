using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AnimowanaRamka
{
    class ButtonShape: Button
    {

        private string btnShape, btnColor;
        private SolidBrush borderBrush;
        private Rectangle borderRectangle;

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

        public override Cursor Cursor { get; set; } = Cursors.Hand;
        public float BorderThickness { get; set; } = 5;

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
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

            borderBrush = new SolidBrush(ColorTranslator.FromHtml("#ff0000"));

            this.Paint += ButtonShape_Paint;
            base.OnPaint(e);
        }

        private void ButtonShape_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath grBorder = new GraphicsPath();

            switch (btnShape)
            {
                case "Rectangle":
                    borderRectangle = new Rectangle(0, 0, Width, Height);
                    e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), borderRectangle);
                    break;
                case "Ellipsis":
                    borderRectangle = new Rectangle(0, 0, Width, Height);
                    e.Graphics.DrawEllipse(new Pen(borderBrush, BorderThickness), borderRectangle);
                    break;
                case "Circle":
                    e.Graphics.DrawEllipse(new Pen(borderBrush, BorderThickness), ClientSize.Width / 3, 0, ClientSize.Width / 3, ClientSize.Height);
                    break;
                case "Square":
                    borderRectangle = new Rectangle(ClientSize.Width / 3, 0, ClientSize.Width / 3, ClientSize.Height);
                    e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), borderRectangle);
                    break;
            }
        }


    }
}
