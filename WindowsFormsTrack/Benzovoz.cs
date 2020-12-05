using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTrack
{
    class Benzovoz
    {
        private float _startPosX;

        private float _startPosY;

        private int _pictureWidth;

        private int _pictureHeight;

        private readonly int BenzWidth = 100;

        private readonly int BenzHeight = 100;

        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }

        public bool Cistern { private set; get; }

        public bool DangerLight { private set; get; }

        public Benzovoz(int maxSpeed, float weight, Color mainColor, Color dopColor, bool cistern, bool dangerLight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Cistern = cistern;
            DangerLight = dangerLight;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - BenzWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - BenzHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawTransport(Graphics g)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(MainColor);
            System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(DopColor);
            Brush brush = new SolidBrush(Color.Black);
            if (Cistern)
            {
                g.FillEllipse(myBrush2, _startPosX + 35, _startPosY + 30, 80, 40);
                g.FillRectangle(myBrush2, _startPosX + 35, _startPosY + 70, 120, 10);
            }
            if (DangerLight)
            {
                g.FillRectangle(myBrush2, _startPosX + 135, _startPosY + 40, 15, 5);
            }
            //Os`
            g.FillRectangle(myBrush, _startPosX + 35, _startPosY + 70, 120, 10);
            g.FillRectangle(myBrush, _startPosX + 120, _startPosY + 45, 35, 25);
            //wheels
            g.FillEllipse(brush, _startPosX + 125, _startPosY + 75, 15, 15);
            g.FillEllipse(brush, _startPosX + 65, _startPosY + 75, 15, 15);
            g.FillEllipse(brush, _startPosX + 46, _startPosY + 75, 15, 15);
        }
    }
}



