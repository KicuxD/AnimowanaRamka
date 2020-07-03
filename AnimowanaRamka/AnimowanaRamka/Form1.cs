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

            btnMain.FlatAppearance.BorderSize = 6;
            btnMain.FlatAppearance.BorderColor = Color.Red;
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

    }
}
