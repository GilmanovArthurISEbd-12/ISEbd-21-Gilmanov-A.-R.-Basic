using System.Drawing;

namespace WindowsFormsTrack
{
    public class Track : Vehicle
    {
        protected readonly int BenzWidth = 100;
       
        protected readonly int BenzHeight = 100;
       
        public Track(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
       
        protected Track(int maxSpeed, float weight, Color mainColor, int benzWidth, int
       benzHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.BenzWidth = benzWidth;
            this.BenzHeight = benzHeight;
        }

        public override void MoveTransport(Direction direction)
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

        public override void DrawTransport(Graphics g)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(MainColor);
            Brush brush = new SolidBrush(Color.Black);
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
