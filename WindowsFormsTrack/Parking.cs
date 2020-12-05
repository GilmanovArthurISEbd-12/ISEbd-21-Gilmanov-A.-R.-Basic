﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrack
{
	class Parking<T> where T : class, ITransport
    {
        private readonly List<T> _places;

        private readonly int _maxCount = 12;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 210;

        private readonly int _placeSizeHeight = 110;
 
        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new List<T>();
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _maxCount = width * height;
        }

        public static bool operator +(Parking<T> p, T track)
        {

            if (p._places.Count >= p._maxCount)
            {
                return false;
            }

            p._places.Add(track);
            return true;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                return null;
            }
            T track = p._places[index];
            p._places.RemoveAt(index);
            return track;
            
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);

            for (int i = 0; i < _places.Count; ++i)
            {
                while (_places[i] == null)
                {
                    i++;
                    if (i == _places.Count)
                    {
                        return;
                    }
                }
                _places[i].SetPosition(4 + i / 4 * _placeSizeWidth + 4, i % 4 *
               _placeSizeHeight, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
                (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
