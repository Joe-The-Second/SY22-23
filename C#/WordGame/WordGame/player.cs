using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame {
    internal class player {
        public string playerName;
        public string item;
        public int playerHP;
        public player(string name, string itemName, int hp) {
            playerName = name;
            item = itemName;
            playerHP = hp;
        }
        public void SubtractHP(int hp) {
            playerHP -= hp;
            if (playerHP == 0) {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You died. Game Over");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public void AddHP(int hp) {
            playerHP += hp;
        }
        public void PickupItem(string itemName) {
            item = itemName;
        }
        public override string ToString() {
            Console.WriteLine("Name: " + playerName);
            Console.WriteLine("Item: " + item);
            Console.WriteLine("HP: " + playerHP);
            return "";
        }
    }
}
