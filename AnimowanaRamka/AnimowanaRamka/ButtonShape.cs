using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace AnimowanaRamka
{
    public class ButtonShape: Button
    {

        private string btnShape, btnColor;

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

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();

            switch(btnShape)
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

            base.OnPaint(e);
        }
    }
}
