using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        double amt = 0;
        public Form1() {
            InitializeComponent();
        }
        private void Cancel() {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void button1_Click(object sender, EventArgs e) {
            if (amt > 500) {
                this.BackColor = Color.Red;
            } else {
                this.BackColor = DefaultBackColor;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Cancel();
        }

        private void textBox5_TextChanged(object sender, EventArgs e) {
            double.TryParse(textBox5.Text, out amt);
            label6.Text = "Fee: $" + (amt * 0.03).ToString();
        }
    }
}
