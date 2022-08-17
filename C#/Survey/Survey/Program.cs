using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey {
    internal class Program {
        static void Main(string[] args) {
            int questionAmt = 0;
            Console.WriteLine("Enter the amount of questions you would like");
            questionAmt = int.Parse(Console.ReadLine());
            string[] questions = new string[questionAmt];
            string[] answer1 = new string[questionAmt];
            string[] answer2 = new string[questionAmt];
            string[] answer3 = new string[questionAmt];
            string[] answer4 = new string[questionAmt];
            string[] correctAnswer = new string[questionAmt];
            string[] chosenAnswer = new string[questionAmt];
            int correct = 0;
            for (int i = 0; i < questionAmt; i++) {
                int questionOn = i + 1;
                Console.WriteLine("Enter question {0}",questionOn);
                questions[i] = Console.ReadLine();
                Console.WriteLine("Enter answer {0}:A",questionOn);
                answer1[i] = Console.ReadLine();
                Console.WriteLine("Enter answer {0}:B",questionOn);
                answer2[i] = Console.ReadLine();
                Console.WriteLine("Enter answer {0}:C",questionOn);
                answer3[i] = Console.ReadLine();
                Console.WriteLine("Enter answer {0}:D",questionOn);
                answer4[i] = Console.ReadLine();
                Console.WriteLine("Enter A,B,C,D (UpperCase) for the correct Answer");
                correctAnswer[i] = Console.ReadLine();
            }
            Console.WriteLine("---------------------------------------------------------");
            for (int i = 0; i < questionAmt; i++) {
                Console.WriteLine(questions[i] + " (UpperCase)");
                Console.WriteLine(answer1[i]);
                Console.WriteLine(answer2[i]);
                Console.WriteLine(answer3[i]);
                Console.WriteLine(answer4[i]);
                chosenAnswer[i] = Console.ReadLine();
                if (chosenAnswer[i] == correctAnswer[i]) {
                    correct += 1;
                }
            }
            Console.WriteLine("You got {0}/{1} correct", correct, questionAmt);
            Console.ReadKey();
        }
    }
}
