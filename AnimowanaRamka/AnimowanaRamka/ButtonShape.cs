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

        private String btnShape;

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();

            switch(btnShape)
            {
                case "ellipse":

                    break;
                case "rectangle":
                    Rectangle pathRect = new Rectangle(20, 20, 100, 200);
                    grPath.AddRectangle(pathRect);
                    this.Region = new System.Drawing.Region(grPath);
                    break;
                default:
                    grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                    this.Region = new System.Drawing.Region(grPath);
                    break;
            }

            base.OnPaint(e);
        }
    }
}
