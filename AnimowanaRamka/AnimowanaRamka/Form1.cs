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
            Console.WriteLine("Hejka naklejka");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            Console.WriteLine(selectedItem);
            Console.WriteLine("Hejka naklejka");

            switch (selectedItem)
            {
                case "rectangle":
                    btnMain.BtnShape = "rectangle";
                    btnMain.Refresh();
                    break;
            }
        }
    }
}
