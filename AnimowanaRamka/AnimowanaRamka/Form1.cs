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
            comboColor.SelectedIndex = 0;
            comboFont.SelectedIndex = 0;
            comboGradColor1.SelectedIndex = 0;


        }

        private void comboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = comboColor.SelectedItem.ToString();

            switch (selectedColor)
            {
                case "Czarny":
                    btnMain.BtnColor = "Black";
                    break;
                case "Czerwony":
                    btnMain.BtnColor = "Red";
                    break;
                case "Biały":
                    btnMain.BtnColor = "White";
                    break;
                case "Żółty":
                    btnMain.BtnColor = "Yellow";
                    break;
                case "Zielony":
                    btnMain.BtnColor = "Green";
                    break;
                case "Niebieski":
                    btnMain.BtnColor = "Blue";
                    break;
            }

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

            switch (selectedColor)
            {
                case "Red":
                    btnMain.CL0 = Color.Red;
                    break;
                case "Black":
                    btnMain.CL0 = Color.Black;
                    break;
                case "Yellow":
                    btnMain.CL0 = Color.Yellow;
                    break;
                case "Green":
                    btnMain.CL0 = Color.Green;
                    break;
                case "Blue":
                    btnMain.CL0 = Color.Blue;
                    break;
            }
        }
    }
}
