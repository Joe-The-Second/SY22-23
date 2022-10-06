using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace Pong {
    internal class Paddle{
        public PictureBox player;
        public Point m_location;
        public Form1 m_parent;
        public Paddle(PictureBox picture, Form1 parent) {
            player = picture;
            m_location = picture.Location;
            m_parent = parent;
        }
        public void Move(int y) {
            m_location = new Point(m_location.X, m_location.Y + y);
            player.Location = m_location;
        }
    }
}
