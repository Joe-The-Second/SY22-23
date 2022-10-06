using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10 {
   
    internal class CarpetCalc {
        string carpetName = "";
        decimal length = 0;
        decimal width = 0;
        decimal cost = 0;
        decimal yardCost;
        public void SetName(String name) {
            carpetName = name;
        }
        public void SetLength(decimal feet, decimal inches) {
            length = (feet + inches/12)/3;
        }
        public void SetWidth(decimal feet, decimal inches) {
            width = (feet + inches / 12) / 3;
        }
        public void SetCostPerYard(decimal costPerYard) {
            yardCost = costPerYard;
            cost = yardCost * width * length;
        }
        public void PrintCarpet() {
            Console.WriteLine("{0}: ${1} per yard. Cost: ${2}",carpetName, yardCost, Decimal.Round(cost, 2));
        }
    }
}
