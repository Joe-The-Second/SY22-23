using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10 {

    internal class CarpetCalc {
        public TextBox widthFeet;
        public TextBox widthInches;
        public TextBox lengthFeet;
        public TextBox lengthInches;
        string carpetName = "";
        public decimal length = 0;
        public decimal width = 0;
        public decimal yardCost = 15.95m;
        public decimal cost = 0;
        public void SetName(String name) {
            carpetName = name;
        }
        public void SetLength(decimal feet, decimal inches) {
            decimal.TryParse(lengthFeet.Text, out feet);
            decimal.TryParse(lengthInches.Text, out inches);
            length = (feet + inches / 12) / 3;
        }
        public void SetWidth(decimal feet, decimal inches) {
            decimal.TryParse(widthFeet.Text, out feet);
            decimal.TryParse(widthInches.Text, out inches);
            width = (feet + inches / 12) / 3;
        }
        public void PrintCarpet(TextBox final) {
            cost = yardCost * width * length;
            final.Text = (Decimal.Round(cost, 2)).ToString();
        }
    }
}
