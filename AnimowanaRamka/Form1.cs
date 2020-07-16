using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamkaAnimowana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFont = comboFont.SelectedItem.ToString();

            switch (selectedFont)
            {
                case "Arial":
                    btnShape.BtnFont = "Arial";
                    break;
                case "Calibri":
                    btnShape.BtnFont = "Calibri";
                    break;
                case "Times New Roman":
                    btnShape.BtnFont = "Times New Roman";
                    break;
                case "Roboto":
                    btnShape.BtnFont = "Roboto";
                    break;
                case "Comic Sans":
                    btnShape.BtnFont = "Comic Sans MS";
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Prostokąt":
                    btnShape.BtnShape = "Rectangle";
                    break;
                case "Elipsa":
                    btnShape.BtnShape = "Ellipsis";
                    break;
                case "Koło":
                    btnShape.BtnShape = "Circle";
                    break;
                case "Kwadrat":
                    btnShape.BtnShape = "Square";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboFont.SelectedIndex = 0;
            comboGradColor1.SelectedIndex = 0;
            comboGradColor2.SelectedIndex = 2;
            comboAnimDirection.SelectedIndex = 0;
        }

        private void comboGradColor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = comboGradColor1.SelectedItem.ToString();

            switch (selectedColor)
            {
                case "beżowy":
                    btnShape.BorderColor1 = Color.Beige;
                    break;
                case "biały":
                    btnShape.BorderColor1 = Color.AntiqueWhite;
                    break;
                case "czarny":
                    btnShape.BorderColor1 = Color.Black;
                    break;
                case "czerwony":
                    btnShape.BorderColor1 = Color.IndianRed;
                    break;
                case "niebieski":
                    btnShape.BorderColor1 = Color.CadetBlue;
                    break;
                case "pomarańczowy":
                    btnShape.BorderColor1 = Color.Orange;
                    break;
                case "różowy":
                    btnShape.BorderColor1 = Color.DeepPink;
                    break;
                case "zielony":
                    btnShape.BorderColor1 = Color.LawnGreen;
                    break;
                case "żółty":
                    btnShape.BorderColor1 = Color.Gold;
                    break;
            }
        }

        private void comboGradColor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor2 = comboGradColor2.SelectedItem.ToString();

            switch (selectedColor2)
            {
                case "beżowy":
                    btnShape.BorderColor2 = Color.Beige;
                    break;
                case "biały":
                    btnShape.BorderColor2 = Color.AntiqueWhite;
                    break;
                case "czarny":
                    btnShape.BorderColor2 = Color.Black;
                    break;
                case "czerwony":
                    btnShape.BorderColor2 = Color.IndianRed;
                    break;
                case "niebieski":
                    btnShape.BorderColor2 = Color.CadetBlue;
                    break;
                case "pomarańczowy":
                    btnShape.BorderColor2 = Color.Orange;
                    break;
                case "różowy":
                    btnShape.BorderColor2 = Color.DeepPink;
                    break;
                case "zielony":
                    btnShape.BorderColor2 = Color.LawnGreen;
                    break;
                case "żółty":
                    btnShape.BorderColor2 = Color.Gold;
                    break;
            }
        }

        private void comboAnimDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDir = comboAnimDirection.SelectedItem.ToString();

            switch (selectedDir)
            {
                case "Prawo":
                    btnShape.AnimDirection = 1;
                    break;
                case "Lewo":
                    btnShape.AnimDirection = -1;
                    break;
            }
        }

        private void btnChgText_Click(object sender, EventArgs e)
        {
            btnShape.BtnText = textBtn.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
