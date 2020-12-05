using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTrack
{
    public partial class FormTrack : Form
    {
        private Benzovoz track;
        public FormTrack()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTracks.Width, pictureBoxTracks.Height);
            Graphics gr = Graphics.FromImage(bmp);
            track.DrawTransport(gr);
            pictureBoxTracks.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            track = new Benzovoz(rnd.Next(100, 400), rnd.Next(1000, 2000), Color.Blue, Color.OrangeRed,
           true, true);
            track.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTracks.Width,
           pictureBoxTracks.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    track.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    track.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    track.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    track.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
