using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10 {
    public partial class Form1 : Form {
        CarpetCalc calc = new CarpetCalc();
        public int widthFeet;
        public int lengthFeet;
        public int widthInches;
        public int lengthInches;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            calc.widthFeet = WidthFeet;
            calc.widthInches = WidthInches;
            calc.lengthFeet = LengthFeet;
            calc.lengthInches = LengthInches;
        }

        private void WidthFeet_TextChanged(object sender, EventArgs e) {
            calc.SetWidth(widthFeet, 0);
            calc.PrintCarpet(FinalCostText);
        }

        private void WidthInches_TextChanged(object sender, EventArgs e) {
            calc.SetWidth(0, widthInches);
            calc.PrintCarpet(FinalCostText);
        }

        private void LengthFeet_TextChanged(object sender, EventArgs e) {
            calc.SetLength(lengthFeet, 0);
            calc.PrintCarpet(FinalCostText);
        }

        private void LengthInches_TextChanged(object sender, EventArgs e) {
            calc.SetLength(0, lengthInches);
            calc.PrintCarpet(FinalCostText); ;
        }

        private void NameText_TextChanged(object sender, EventArgs e) {
            calc.SetName(NameText.Text);
        }
    }
}
