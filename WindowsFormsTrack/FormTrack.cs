using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsTrack;

namespace WindowsFormsTrack
{
	public partial class FormBenzovoz : Form
	{
		private ITransport Benzo;
		public FormBenzovoz()
		{
			InitializeComponent();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxBenzo.Width, pictureBoxBenzo.Height);
			Graphics gr = Graphics.FromImage(bmp);
			Benzo.DrawTransport(gr);
			pictureBoxBenzo.Image = bmp;
		}
		
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			Benzo = new Benzovoz(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.OrangeRed,
		   true, true);
			Benzo.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBenzo.Width,
		   pictureBoxBenzo.Height);
			Draw();
		}

		private void buttonCreateTrack_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			Benzo = new Track(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
			Benzo.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBenzo.Width,
			pictureBoxBenzo.Height);
			Draw();

		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					Benzo.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					Benzo.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					Benzo.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					Benzo.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}
