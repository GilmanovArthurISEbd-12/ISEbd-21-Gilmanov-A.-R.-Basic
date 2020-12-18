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
    public partial class FormTrackConfig : Form
    {

        Vehicle track = null;

        private event Action<Vehicle> eventActionAddTrack;
        public FormTrackConfig()
        {
            InitializeComponent();
            foreach (var item in groupColors.Controls)
            {
                if (item is Panel)
                {
                    ((Panel)item).MouseDown += panelColor_MouseDown;
                }
            }
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            track?.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            DrawTrack();
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (track is Benzovoz)
            {
                (track as Benzovoz).SetDopColor((Color)(e.Data.GetData(typeof(Color))));
                DrawTrack();
            }
        }

        private void DrawTrack()
        {
            if (track != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTrack.Width, pictureBoxTrack.Height);
                Graphics gr = Graphics.FromImage(bmp);
                track.SetPosition(5, 5, pictureBoxTrack.Width, pictureBoxTrack.Height);
                track.DrawTransport(gr);
                pictureBoxTrack.Image = bmp;
            }
        }
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventActionAddTrack == null)
            {
                eventActionAddTrack = new Action<Vehicle>(ev);
            }
            else
            {
                eventActionAddTrack += ev;
            }
        }
        private void labelTrack_MouseDown(object sender, MouseEventArgs e)
        {
            labelTrack.DoDragDrop(labelTrack.Text, DragDropEffects.Move |
            DragDropEffects.Copy);
        }

        private void labelBenzovoz_MouseDown(object sender, MouseEventArgs e)
        {
            labelBenzovoz.DoDragDrop(labelBenzovoz.Text, DragDropEffects.Move |
            DragDropEffects.Copy);
        }

        private void panelTrack_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelTrack_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный грузовик":
                    track = new Track((int)numericUpDownMaxSpeed.Value,
                   (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Бензовоз":
                    track = new Benzovoz((int)numericUpDownMaxSpeed.Value,
                   (int)numericUpDownWeight.Value, Color.White, Color.White,
                    checkBoxDangerLight.Checked, checkBoxCistern.Checked);
                    break;
            }
            DrawTrack();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventActionAddTrack.Invoke(track);
            Close();
        }
    }
}
