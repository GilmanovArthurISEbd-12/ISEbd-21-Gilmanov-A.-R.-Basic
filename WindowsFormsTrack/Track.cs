﻿using System;
using System.Drawing;
namespace WindowsFormsTrack
{
    public class Track : Vehicle, IEquatable<Track>
    {
        protected readonly int trackWidth = 100;
      
        protected readonly int trackHeight = 100;
    
        protected readonly char separator = ';';
  
        public Track(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Track(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        protected Track(int maxSpeed, float weight, Color mainColor, int trackWidth, int
       trackHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.trackWidth = trackWidth;
            this.trackHeight = trackHeight;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - trackWidth)
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
                    if (_startPosY + step < _pictureHeight - trackHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(MainColor);
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 4);

            //ось
            g.FillRectangle(myBrush, _startPosX + 5, _startPosY + 50, 85, 10);
            //кабина
            g.FillRectangle(myBrush, _startPosX + 55, _startPosY + 30, 35, 20);
            //Колеса
            g.DrawEllipse(blackPen, _startPosX + 10, _startPosY + 60, 12, 10);
            g.DrawEllipse(blackPen, _startPosX + 30, _startPosY + 60, 12, 10);
            g.DrawEllipse(blackPen, _startPosX + 65, _startPosY + 60, 12, 10);

        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }

        public bool Equals(Track other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Track trackObj))
            {
                return false;
            }
            else
            {
                return Equals(trackObj);
            }
        }
    }

}
