using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace Pong {
    internal class Ball{
        public PictureBox ball;
        public Point m_location;
        public Form1 m_parent;
        public double xSpeed = 1;
        public double ySpeed = 1;
        public int p1Points = 0;
        public int p2Points = 0;
        public Ball(PictureBox picture, Form1 parent) {
            ball = picture;
            m_location = picture.Location;
            m_parent = parent;
        }
        public void ChangeYdir() {
            if (m_location.Y < 12 || m_location.Y > 355) {
                ySpeed *= -1.05;
            }
        }
        public void ChangeXdir() {
            xSpeed *= -1.05;
        }
        public void BallWin() {
            if (p1Points == 9) {
                Environment.Exit(0);
            }
            if (p2Points == 9) {
                Environment.Exit(0);
            }
            if (m_location.X < -10) {
                p2Points += 1;
                xSpeed = -1;
                ySpeed = 1;
                m_location = new Point(300, 175);
            }
            if (m_location.X > 600) {
                p1Points += 1;
                xSpeed = 1;
                ySpeed = 1;
                m_location = new Point(300, 175);
            }
        }
        public void Move(int x, int y) {
            m_location = new Point(m_location.X + (int)Math.Round(x * xSpeed),  m_location.Y + (int)Math.Round(y * ySpeed));
            ball.Location = m_location;
        }
    }
}
