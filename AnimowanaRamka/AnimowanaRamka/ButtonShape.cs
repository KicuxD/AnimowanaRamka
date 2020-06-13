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

        private string btnShape = "rectangle";

        public string BtnShape
        {
            get { return btnShape; }
            set { btnShape = value; }
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();

            if (btnShape == "rectangle")
            {
                Rectangle pathRect = new Rectangle(20, 20, 100, 300);
                grPath.AddRectangle(pathRect);
                this.Region = new System.Drawing.Region(grPath);
            } else if (btnShape == "elipsa") {
                grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new System.Drawing.Region(grPath);
            }

            base.OnPaint(e);
        }
    }
}
