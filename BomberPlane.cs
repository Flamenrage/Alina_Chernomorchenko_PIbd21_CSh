using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Plane_project
{
   public class BomberPlane
    {
        private float _startPosX;
        
        private float _startPosY;
       
        private int _pictureWidth;
       
        private int _pictureHeight;
       
        private const int carWidth = 200;
        
        private const int carHeight = 150;
       
        public int MaxSpeed { private set; get; }
       
        public float Weight { private set; get; }
        
        public Color MainColor { private set; get; }
        
        public Color DopColor { private set; get; }
        public bool Bombs { private set; get; }
        public bool Shoot { private set; get; }
      
        public BomberPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
      bombs, bool shoot)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Bombs = bombs;
           Shoot = shoot;
        }
        
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 60 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth + 40)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step  > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step  > 30)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight )
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }        public void DrawPlane(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 5);
          
            if (Bombs)
            {

                Pen pen1 = new Pen(Color.Black, 2);
                g.DrawEllipse(pen1, _startPosX + 133, _startPosY - 30, 15, 10);
                g.DrawEllipse(pen1, _startPosX + 140, _startPosY - 5, 15, 10);
                g.DrawEllipse(pen1, _startPosX + 140, _startPosY + 20, 15, 10);

                g.DrawEllipse(pen1, _startPosX + 133, _startPosY + 130, 15, 10);
                g.DrawEllipse(pen1, _startPosX + 140, _startPosY + 105, 15, 10);
                g.DrawEllipse(pen1, _startPosX + 140, _startPosY + 80, 15, 10);

                Brush spoiler = new SolidBrush(DopColor);
               
              
                g.FillEllipse(spoiler, _startPosX + 133, _startPosY - 30, 15, 10);
                g.FillEllipse(spoiler, _startPosX + 140, _startPosY - 5, 15, 10);
                g.FillEllipse(spoiler, _startPosX + 140, _startPosY + 20, 15, 10);

                g.FillEllipse(spoiler, _startPosX + 133, _startPosY + 130, 15, 10);
                g.FillEllipse(spoiler, _startPosX + 140, _startPosY + 105, 15, 10);
                g.FillEllipse(spoiler, _startPosX + 140, _startPosY + 80, 15, 10);

            }
            
           
            g.DrawEllipse(pen, _startPosX + 20, _startPosY + 33, 140, 44);
            g.DrawRectangle(pen, _startPosX + 30, _startPosY + 23, 20, 64);
        
            g.DrawEllipse(pen, _startPosX + 100, _startPosY - 32, 30, 180);
          
            Brush brRed = new SolidBrush(Color.Red);
            
            Brush brYellow = new SolidBrush(Color.Yellow);
         
            Brush br = new SolidBrush(MainColor);
            
            g.FillEllipse(br, _startPosX + 20, _startPosY + 33, 140, 44);
            g.FillRectangle(br, _startPosX + 30, _startPosY + 23, 20, 64);
            g.FillEllipse(br, _startPosX + 100, _startPosY - 32, 30, 180);
           
            if (Shoot)
            {
                Pen pen1 = new Pen(Color.Black, 2);
                g.DrawEllipse(pen1, _startPosX + 90, _startPosY + 42, 30, 20);
                Brush spoiler = new SolidBrush(Color.FromArgb(0, 236, 255));

                g.FillEllipse(spoiler, _startPosX + 90, _startPosY + 42, 30, 20);
            }

        }
    }
}
