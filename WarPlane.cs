using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plane_project
{
    public class WarPlane : AirVehicle
    {
        protected const int planeWidth = 150;

        protected const int planeHeight = 100;

        public WarPlane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth)
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
                    if (_startPosY + step < _pictureHeight - planeHeight)

                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawPlane(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 5);

            //границы автомобиля
            g.DrawEllipse(pen, _startPosX + 20 / 3, _startPosY + 33 / 3 , 140 / 3, 44 / 3);
            g.DrawRectangle(pen, _startPosX + 30 / 3, _startPosY + 23 / 3, 20 / 3, 64 / 3);

            g.DrawEllipse(pen, _startPosX + 100 / 3, _startPosY - 32 / 3, 30 / 3, 180 / 3);

            Brush br = new SolidBrush(MainColor);

            g.FillEllipse(br, _startPosX + 20 / 3, _startPosY + 33 / 3, 140 / 3, 44 / 3);
            g.FillRectangle(br, _startPosX + 30 / 3, _startPosY + 23 / 3, 20 / 3, 64 / 3);
            g.FillEllipse(br, _startPosX + 100 / 3, _startPosY - 32 / 3, 30 / 3, 180 / 3);
            Pen pen2 = new Pen(Color.Black, 2);
            g.DrawEllipse(pen2, _startPosX + 90 / 3 , _startPosY + 42 / 3, 30 / 3, 20 / 3);
            Brush spoiler = new SolidBrush(Color.FromArgb(0, 236, 255));
            g.FillEllipse(spoiler, _startPosX + 90 / 3, _startPosY + 42 / 3, 30 / 3, 20 / 3);

        }
    }
}
