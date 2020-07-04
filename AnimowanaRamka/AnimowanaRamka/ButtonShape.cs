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

        public float BorderThickness { get; set; } = 5;
        public object KeyTime { get; private set; }
        public object RepeatBehavior { get; private set; }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {

            this.Text = BtnText;

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

            //borderBrush = new SolidBrush(ColorTranslator.FromHtml("#ff0000"));

        //public ColorAnimationUsingKeyFramesExample()
            //{
                // Create the Border that is the target of the animation.
                SolidBrush borderBrush = new SolidBrush(Color);
                borderBrush.Color = Color.FromArgb(255, 0, 255, 0);

                // Set the initial color of the border to green.
                borderRectangle.BorderBrush = borderBrush;
                borderRectangle.BorderThickness = new Thickness(28);
                borderRectangle.Padding = new Thickness(20);
                myStackPanel.Children.Add(myBorder);

                // Assign the Brush a name so that
                // it can be targeted by a Storyboard.
                this.RegisterName("borderBrush", borderBrush);

                // Create a ColorAnimationUsingKeyFrames to
                // animate the BorderBrush property of the Button.
                ColorAnimationUsingKeyFrames colorAnimation = new ColorAnimationUsingKeyFrames();
                colorAnimation.Duration = TimeSpan.FromSeconds(6);

                // Create brushes to use as animation values.
                Color redColor = new Color();
                redColor = Color.FromArgb(255, 255, 0, 0);
                Color yellowColor = new Color();
                yellowColor = Color.FromArgb(255, 255, 255, 0);
                Color greenColor = new Color();
                greenColor = Color.FromArgb(255, 0, 255, 0);

                // Go from green to red in the first 2 seconds. LinearColorKeyFrame creates
                // a smooth, linear animation between values.
                colorAnimation.KeyFrames.Add(
                    new LinearColorKeyFrame(
                        redColor, // Target value (KeyValue)
                        KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2.0))) // KeyTime
                    );

                // In the next half second, go to yellow. DiscreteColorKeyFrame creates a
                // sudden jump between values.
                colorAnimation.KeyFrames.Add(
                    new DiscreteColorKeyFrame(
                        yellowColor, // Target value (KeyValue)
                        KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2.5))) // KeyTime
                    );

                // In the final 2 seconds of the animation, go from yellow back to green. SplineColorKeyFrame
                // creates a variable transition between values depending on the KeySpline property. In this example,
                // the animation starts off slow but toward the end of the time segment, it speeds up exponentially.
                colorAnimation.KeyFrames.Add(
                    new SplineColorKeyFrame(
                        greenColor, // Target value (KeyValue)
                        KeyTime.FromTimeSpan(TimeSpan.FromSeconds(4.5)), // KeyTime
                        new KeySpline(0.6, 0.0, 0.9, 0.0) // KeySpline
                        )
                    );

                // Set the animation to repeat forever.
                colorAnimation.RepeatBehavior = RepeatBehavior.Forever;
            //}

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
                    borderRectangle = new Rectangle(ClientSize.Width / 3, 0, ClientSize.Width / 3, ClientSize.Height);
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
