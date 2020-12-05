using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsTrack;

namespace WindowsFormsTrack
{
    class Benzovoz : Track
    {
        
        public Color DopColor { private set; get; }
        
        public bool Cistern { private set; get; }
        
        public bool DangerLight { private set; get; }
       
        public Benzovoz(int maxSpeed, float weight, Color mainColor, Color dopColor, bool cistern, bool dangerlight) : 
            base(maxSpeed, weight, mainColor, 100, 100)
        {
            DopColor = dopColor;
            Cistern = cistern;
            DangerLight = dangerlight;
        }
        
        public override void DrawTransport(Graphics g)
        {
            System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(DopColor);

            if (Cistern)
            {
                g.FillEllipse(myBrush2, _startPosX + 35, _startPosY + 30, 80, 40);
                g.FillRectangle(myBrush2, _startPosX + 35, _startPosY + 70, 120, 10);
            }
            if (DangerLight)
            {
                g.FillRectangle(myBrush2, _startPosX + 135, _startPosY + 40, 15, 5);
            }

            base.DrawTransport(g);
        }
    }
}
