using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            double amt = 0;
            double.TryParse(textBox1.Text, out amt);
            label1.Text = "V-Bucks: " + (amt * 159.29).ToString();
            label2.Text = "Robux: " + (amt * 94.05).ToString();
            label3.Text = "Minecoins: " + (amt * 174.55).ToString();
            label4.Text = "Monkey Money: " + (amt * 628.15).ToString();
            label5.Text = "Hypixel Gems: " + (amt * 154.55).ToString();
            label6.Text = "Clash of Clans Gems: " + (amt * 133.23).ToString();
        }
    }
}
