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
                g.DrawRectangle(pen2, _startPosX + 30, _startPosY + 20, 30, 5);
                g.DrawRectangle(pen2, _startPosX + 30, _startPosY + 83, 30, 5);
                Brush brush2 = new SolidBrush(DopColor);
                g.FillRectangle(brush2, _startPosX + 30, _startPosY + 20, 30, 5);
                g.FillRectangle(brush2, _startPosX + 30, _startPosY + 83, 30, 5);


            }
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
            base.DrawPlane(g);



        }
    }
}
