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
    public partial class FormParking : Form
    {
        private readonly Parking<Vehicle> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Vehicle>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonSetTrack_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var track = new Track(100, 1000, dialog.Color);
            if (parking + track)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void buttonSetBenzovoz_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var track = new Benzovoz(100, 1000, dialog.Color, dialogDop.Color,
                   true, true);
                    if (parking + track)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        private void buttonPickUpTrack_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxParking.Text != "")
            {
                var track = parking - Convert.ToInt32(maskedTextBoxParking.Text);
                Draw();

                if (track != null)
                {
                    FormTrack form = new FormTrack();
                    form.SetTrack(track);
                    form.ShowDialog();
                } 
            }
        }
    }
}
