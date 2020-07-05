using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimowanaRamka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();


            switch (selectedItem)
            {
                case "Prostokąt":
                    btnMain.BtnShape = "Rectangle";
                    break;
                case "Elipsa":
                    btnMain.BtnShape = "Ellipsis";
                    break;
                case "Koło":
                    btnMain.BtnShape = "Circle";
                    break;
                case "Kwadrat":
                    btnMain.BtnShape = "Square";
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

        private void btnChgText_Click(object sender, EventArgs e)
        {
            btnMain.BtnText = textBtn.Text;
        }

        private void comboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFont = comboFont.SelectedItem.ToString();

            switch (selectedFont)
            {
                case "Arial":
                    btnMain.BtnFont = "Arial";
                    break;
                case "Calibri":
                    btnMain.BtnFont = "Calibri";
                    break;
                case "Times New Roman":
                    btnMain.BtnFont = "Times New Roman";
                    break;
                case "Roboto":
                    btnMain.BtnFont = "Roboto";
                    break;
                case "Comic Sans":
                    btnMain.BtnFont = "Comic Sans MS";
                    break;
            }
        }

        private void comboGradColor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = comboGradColor1.SelectedItem.ToString();

            /*
             *  beżowy
                biały
                czarny
                czerwony
                niebieski
                pomarańczowy
                różowy
                zielony
                żółty
             */

            switch (selectedColor)
            {
                case "beżowy":
                    btnMain.CL0 = Color.Beige;
                    break;
                case "biały":
                    btnMain.CL0 = Color.AntiqueWhite;
                    break;
                case "czarny":
                    btnMain.CL0 = Color.Black;
                    break;
                case "czerwony":
                    btnMain.CL0 = Color.IndianRed;
                    break;
                case "niebieski":
                    btnMain.CL0 = Color.CadetBlue;
                    break;
                case "pomarańczowy":
                    btnMain.CL0 = Color.Orange;
                    break;
                case "różowy":
                    btnMain.CL0 = Color.DeepPink;
                    break;
                case "zielony":
                    btnMain.CL0 = Color.LawnGreen;
                    break;
                case "żółty":
                    btnMain.CL0 = Color.Gold;
                    break;
            }
        }

        private void comboGradColor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor2 = comboGradColor2.SelectedItem.ToString();

            /*
             *  beżowy
                biały
                czarny
                czerwony
                niebieski
                pomarańczowy
                różowy
                zielony
                żółty
             */

            switch (selectedColor2)
            {
                case "beżowy":
                    btnMain.CL1 = Color.Beige;
                    break;
                case "biały":
                    btnMain.CL1 = Color.AntiqueWhite;
                    break;
                case "czarny":
                    btnMain.CL1 = Color.Black;
                    break;
                case "czerwony":
                    btnMain.CL1 = Color.IndianRed;
                    break;
                case "niebieski":
                    btnMain.CL1 = Color.CadetBlue;
                    break;
                case "pomarańczowy":
                    btnMain.CL1 = Color.Orange;
                    break;
                case "różowy":
                    btnMain.CL1 = Color.DeepPink;
                    break;
                case "zielony":
                    btnMain.CL1 = Color.LawnGreen;
                    break;
                case "żółty":
                    btnMain.CL1 = Color.Gold;
                    break;
            }
        }

        private void comboAnimDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDir = comboAnimDirection.SelectedItem.ToString();

            switch (selectedDir)
            {
                case "Prawo":
                    btnMain.AnimDirection = 1;
                    break;
                case "Lewo":
                    btnMain.AnimDirection = -1;
                    break;
            }

        }
    }
}
