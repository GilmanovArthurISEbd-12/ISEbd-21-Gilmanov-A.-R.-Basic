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
        private readonly ParkingCollection parkingCollection;

        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
        }

        private void ReloadLevels()
        {
            int index = listBoxParking.SelectedIndex;
            listBoxParking.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParking.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParking.Items.Count > 0 && (index == -1 || index >=
          listBoxParking.Items.Count))
            {
                listBoxParking.SelectedIndex = 0;
            }
            else if (listBoxParking.Items.Count > 0 && index > -1 && index <
           listBoxParking.Items.Count)
            {
                listBoxParking.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxParking.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
               pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParking.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }

        }

        private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPlace.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(textBoxPlace.Text);
            ReloadLevels();
        }

        private void buttonDelParking_Click(object sender, EventArgs e)
        {
            if (listBoxParking.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { listBoxParking.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    parkingCollection.DelParking(listBoxParking.Text);
                    ReloadLevels();
                }
            }
        }

        private void buttonSetTrack_Click(object sender, EventArgs e)
        {
            if (listBoxParking.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var track = new Track(100, 1000, dialog.Color);
                    if (parkingCollection[listBoxParking.SelectedItem.ToString()] +
                   track)
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
        private void buttonSetBenzovoz_Click(object sender, EventArgs e)
        {
            if (listBoxParking.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var car = new Benzovoz(100, 1000, dialog.Color,
                       dialogDop.Color, true, true);
                        if (parkingCollection[listBoxParking.SelectedItem.ToString()] + car)
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

        }

        private void buttonPickUpTrack_Click(object sender, EventArgs e)
        {
            if (listBoxParking.SelectedIndex > -1 && maskedTextBoxParking.Text != "")
            {
                var track = parkingCollection[listBoxParking.SelectedItem.ToString()] -
               Convert.ToInt32(maskedTextBoxParking.Text);
                if (track != null)
                {
                    FormTrack form = new FormTrack();
                    form.SetTrack(track);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void listBoxParking_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
