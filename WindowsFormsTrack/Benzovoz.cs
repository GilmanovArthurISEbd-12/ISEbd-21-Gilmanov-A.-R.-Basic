using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrack
{
    class Benzovoz  : Track
    {
        public Color DopColor { private set; get; }

        public bool DangerLight { private set; get; }

        public bool Cistern { private set; get; }

        public Benzovoz(int maxSpeed, float weight, Color mainColor, Color dopColor, bool dangerLight, bool cistern) : 
            base(maxSpeed, weight, mainColor, 100, 100)
        {
            MainColor = mainColor;
            DopColor = dopColor;
            DangerLight = dangerLight;
            Cistern = cistern;
        }

        public Benzovoz(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                DangerLight = Convert.ToBoolean(strs[4]);
                Cistern = Convert.ToBoolean(strs[5]);
            }
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override void DrawTransport(Graphics g)
        {
            System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(DopColor);

            if (DangerLight)
            {
                g.FillRectangle(myBrush2, _startPosX + 70, _startPosY + 25, 15, 5);
            }

            if (Cistern)
            {
                g.FillEllipse(myBrush2, _startPosX + 5, _startPosY + 30, 50, 20);
            }

            base.DrawTransport(g);
        }

        public override string ToString()
        {
           return
           $"{base.ToString()}{separator}{DopColor.Name}{separator}{Cistern}{separator}{DangerLight}";
        }
    }
}
