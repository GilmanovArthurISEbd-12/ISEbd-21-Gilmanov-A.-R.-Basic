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
		private ITransport track;

		public FormTrack()
		{
			InitializeComponent();
		}

		public void SetTrack(ITransport track)
		{
			this.track = track;
			Draw();
	    }

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxTrack.Width, pictureBoxTrack.Height);
			Graphics gr = Graphics.FromImage(bmp);
			track?.DrawTransport(gr);
			pictureBoxTrack.Image = bmp;
		}
		
		private void buttonCreateBenzovoz_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			track = new Benzovoz(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Black,
		   true, true);
			track.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTrack.Width,
		   pictureBoxTrack.Height);
			Draw();
		}

		private void buttonCreatePlane_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			track = new Track(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
			track.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTrack.Width,
		   pictureBoxTrack.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					track?.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					track?.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					track?.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					track?.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}
