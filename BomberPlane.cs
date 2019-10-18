using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Plane_project
{
   public class BomberPlane : WarPlane
    {
        
        
        public Color DopColor { private set; get; }
        public bool Bombs { private set; get; }
        public bool Shoot { private set; get; }
        public BomberPlane(int maxSpeed, float weight, Color mainColor, Color dopColor,
  bool bombs, bool shoot) :
   base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Bombs = bombs;
            Shoot = shoot;
        }
     
                public override void DrawPlane(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 5);

            if (Shoot)
            {
                Pen pen2 = new Pen(Color.Black, 5);
                g.DrawRectangle(pen2, _startPosX + 30 / 3 , _startPosY + 20 / 3, 30 / 3, 5 / 3);
                g.DrawRectangle(pen2, _startPosX + 30 / 3, _startPosY + 83 / 3, 30 / 3, 5 / 3);
                Brush brush2 = new SolidBrush(DopColor);
                g.FillRectangle(brush2, _startPosX + 30 / 3, _startPosY + 20 / 3, 30 / 3, 5 / 3);
                g.FillRectangle(brush2, _startPosX + 30 / 3, _startPosY + 83 / 3, 30 / 3, 5 / 3);


            }
            if (Bombs)
            {

                Pen pen1 = new Pen(Color.Black, 1);
                g.DrawEllipse(pen1, _startPosX + 133 / 3, _startPosY - 30 / 3, 15 / 3, 10 / 3);
                g.DrawEllipse(pen1, _startPosX + 140 / 3, _startPosY - 5 / 3, 15 / 3, 10 / 3);
                g.DrawEllipse(pen1, _startPosX + 140 / 3, _startPosY + 20 / 3, 15 / 3, 10 / 3);

                g.DrawEllipse(pen1, _startPosX + 133 / 3, _startPosY + 130 / 3, 15 / 3, 10 / 3);
                g.DrawEllipse(pen1, _startPosX + 140 / 3, _startPosY + 105 / 3, 15 / 3, 10 / 3);
                g.DrawEllipse(pen1, _startPosX + 140 / 3, _startPosY + 80 / 3, 15 / 3, 10 / 3);

                Brush spoiler = new SolidBrush(DopColor);
               
              
                g.FillEllipse(spoiler, _startPosX + 133 / 3, _startPosY - 30 / 3, 15 / 3, 10 / 3);
                g.FillEllipse(spoiler, _startPosX + 140 / 3, _startPosY - 5 / 3, 15 / 3, 10 / 3);
                g.FillEllipse(spoiler, _startPosX + 140 / 3, _startPosY + 20 / 3, 15 / 3, 10 / 3);

                g.FillEllipse(spoiler, _startPosX + 133 / 3, _startPosY + 130 / 3, 15 / 3, 10 / 3);
                g.FillEllipse(spoiler, _startPosX + 140 / 3, _startPosY + 105 / 3, 15 / 3, 10 / 3);
                g.FillEllipse(spoiler, _startPosX + 140 / 3, _startPosY + 80 / 3, 15 / 3, 10 / 3);

            }
            base.DrawPlane(g);



        }
    }
}
