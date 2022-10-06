using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong {
    public partial class Form1 : Form {
        Paddle p1;
        Paddle p2;
        Ball b;
        bool p1Up, p1Down, p2Up, p2Down;
        public Form1() {
            InitializeComponent();
            p1 = new Paddle(player1, this);
            p2 = new Paddle(player2, this);
            b = new Ball(ball, this);
        }
        public void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.W && player1.Location.Y > 12) {
                p1Up = true;
                p1Down = false;
            }
            if (e.KeyCode == Keys.S && player1.Location.Y < 300) {
                p1Up = false;
                p1Down = true;
            }
            if (e.KeyCode == Keys.Up && player2.Location.Y > 12) {
                p2Up = true;
                p2Down = false;
            }
            if (e.KeyCode == Keys.Down && player2.Location.Y < 300) {
                p2Up = false;
                p2Down = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e) {
            PointsText.Text = b.p1Points + ":" + b.p2Points;
            b.BallWin();
            b.Move(3, -1);
            b.ChangeYdir();
            if (p1Up == true && player1.Location.Y > 12) {
                p1.Move(-4);
            } else if (p1Down == true && player1.Location.Y < 300) {
                p1.Move(4);
            }
            if (p2Up == true && player2.Location.Y > 12) {
                p2.Move(-4);
            } else if (p2Down == true && player2.Location.Y < 300) {
                p2.Move(4);
            }
            if (ball.Location.X > player1.Location.X && ball.Location.X < player1.Location.X + 15 && ball.Location.Y > player1.Location.Y - 5 && ball.Location.Y < player1.Location.Y + 70) {
                b.ChangeXdir();
            }
            if (ball.Location.X > player2.Location.X - 15 && ball.Location.X < player2.Location.X + 15 && ball.Location.Y > player2.Location.Y && ball.Location.Y < player2.Location.Y + 75) {
                b.ChangeXdir();
            }
        }
    }
}
