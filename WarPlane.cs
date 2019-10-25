﻿using System;
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
            int a = 3;
            Pen pen = new Pen(Color.Black, 5);

            //границы автомобиля
            g.DrawEllipse(pen, _startPosX + 20 / a, _startPosY + 33 / a , 140 / a, 44 / a);
            g.DrawRectangle(pen, _startPosX + 30 / a, _startPosY + 23 / a, 20 / a, 64 / a);

            g.DrawEllipse(pen, _startPosX + 100 / a, _startPosY - 32 / a, 30 / a, 180 / a);

            Brush br = new SolidBrush(MainColor);

            g.FillEllipse(br, _startPosX + 20 / a, _startPosY + 33 / a, 140 / a, 44 / a);
            g.FillRectangle(br, _startPosX + 30 / a, _startPosY + 23 / a, 20 / a, 64 / a);
            g.FillEllipse(br, _startPosX + 100 / a, _startPosY - 32 / a, 30 / a, 180 / a);
            Pen pen2 = new Pen(Color.Black, 2);
            g.DrawEllipse(pen2, _startPosX + 90 / a , _startPosY + 42 / a, 30 / a, 20 / a);
            Brush spoiler = new SolidBrush(Color.FromArgb(0, 236, 255));
            g.FillEllipse(spoiler, _startPosX + 90 / a, _startPosY + 42 / a, 30 / a, 20 / a);

        }
    }
}
