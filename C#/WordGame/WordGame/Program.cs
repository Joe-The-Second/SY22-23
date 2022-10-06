using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WordGame {
    internal class Program {
        static void Main(string[] args) {
            int answer;
            int number = 0;
            string spacer = "-----------------------------------------------------------------------------------------------------------------------";
            string space = " ";
            WriteLine("Enter Your name:");
            string name = ReadLine();
            player p = new player(name, "Hand", 100);
            WriteLine(space);
            WriteLine("Hello {0}, I am Duke of the highlands, man whom was birthed from stone and dust, created in the forges of Mount Dooku.  I am here to guide you.", name);
            WriteLine(space);
            WriteLine("Do you choose to leave(1) or follow(2) him?");
            answer = int.Parse(ReadLine());
            WriteLine(space);
            if (answer == 1) {
                WriteLine("Ok {0}, but you will regret that, for I am Duke of the highlands, man whom was birthed from stone and dust, created in  the forges of Mount Dooku.", name);
                p.SubtractHP(25);
                WriteLine(p);
                number = 1;
            } else if (answer == 2) {
                WriteLine("Lets head to that village {0}, for I am Duke of the highlands, man whom was birthed from stone and dust, created in the forges of Mount Dooku.", name);
                p.AddHP(25);
                WriteLine(p);
                number = 2;
            }
            WriteLine(spacer);
            if (number == 1) {
                WriteLine("You travel and get lost, you find a knife and a rat next to it. Do you fight(1) or run(2)?");
                answer = int.Parse(ReadLine());
                if (answer == 1) {
                    p.SubtractHP(50);
                    WriteLine("You got the Knife, and you go back to fight the Duke");
                    p.item = "Knife";
                    WriteLine(p);
                }
                if (answer == 2) {
                    WriteLine("The rat still sees you, and becuase you dont have any weapons, you die.");
                    p.SubtractHP(75);
                }
            } else if (number == 2) {
                    WriteLine("I am acctually Evil, for I am Duke of higlands, man whom was birthed from stone and dust, created in the forges of   Mount Dooku. You will Die.");
                    p.SubtractHP(125);
            }
            Console.WriteLine("You see the Duke, do you fight him(1) or run(2)?");
            answer = int.Parse(ReadLine());
            if (answer == 1) {
                WriteLine("I see you have a kinfe, sadly I, Duke of higlands, man whom was birthed from stone and dust, created in the forges of   Mount Dooku, will kill you.");
                p.SubtractHP(25);
            }
            if (answer == 2) {
                WriteLine("You run, but sadly, you fall into a trap and die.");
                p.SubtractHP(25);
            }
            ReadLine();
        }
    }
}
