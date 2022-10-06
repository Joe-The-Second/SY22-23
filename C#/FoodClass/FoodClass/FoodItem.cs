using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodClass {
    internal class FoodItem {
        const int cFatCalories = 9;
        const int cProteinCalories = 4;
        const int cCarbCalories = 4;
        string m_name;
        int m_fatGrams;
        int m_proteinGrams;
        int m_carbGrams;
        public FoodItem(string name, int fatGrams, int proteinGrams, int carbGrams) {
            m_name = name;
            m_fatGrams = fatGrams;
            m_proteinGrams = proteinGrams;
            m_carbGrams = carbGrams;
        }
        public int getFatGrams() {
            return m_fatGrams * 9;
        }
        public int getProteinGrams() {
            return m_proteinGrams * 4;
        }
        public int getCarbsGrams() {
            return m_carbGrams * 4;
        }
        public decimal TotalCalories() {
            return getFatGrams() + getProteinGrams() + getCarbsGrams();
        }
        public decimal percentageOfFat() {
            return (getFatGrams() / TotalCalories()) * 100;
        }

        public override string ToString() {
            return m_name + ":\n" + "Fat: " + m_fatGrams + "\n" + "Protein: " + m_proteinGrams + "\n" + "Carbs: " + m_carbGrams + "\n" + "Calories: " + TotalCalories() + "\n" + "Percentage Of Fat: " + Decimal.Round(percentageOfFat(), 2) + "%";
        }
    }
}
