using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Plane_project
{
   public class BomberPlane : WarPlane, IComparable<BomberPlane>, IEquatable<BomberPlane>
    {

        public void SetDopColor(Color color)
        {
            DopColor = color;

        }
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
        public BomberPlane(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Bombs= Convert.ToBoolean(strs[4]);
                Shoot = Convert.ToBoolean(strs[5]);
            }
        }
        public override void DrawPlane(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 5);
            int a = 3;
            if (Shoot)
            {
                Pen pen2 = new Pen(Color.Black, 5);
                g.DrawRectangle(pen2, _startPosX + 30 / a , _startPosY + 20 / a, 30 / a, 5 / a);
                g.DrawRectangle(pen2, _startPosX + 30 / a, _startPosY + 83 / a, 30 / a, 5 / a);
                Brush brush2 = new SolidBrush(DopColor);
                g.FillRectangle(brush2, _startPosX + 30 / a, _startPosY + 20 / a, 30 / a, 5 / a);
                g.FillRectangle(brush2, _startPosX + 30 / a, _startPosY + 83 / a, 30 / a, 5 / a);


            }
            if (Bombs)
            {

                Pen pen1 = new Pen(Color.Black, 1);
                g.DrawEllipse(pen1, _startPosX + 133 / a, _startPosY - 30 / a, 15 / a, 10 / a);
                g.DrawEllipse(pen1, _startPosX + 140 / a, _startPosY - 5 / a, 15 / a, 10 / a);
                g.DrawEllipse(pen1, _startPosX + 140 / a, _startPosY + 20 / a, 15 / a, 10 / a);

                g.DrawEllipse(pen1, _startPosX + 133 / a, _startPosY + 130 / a, 15 / a, 10 / a);
                g.DrawEllipse(pen1, _startPosX + 140 / a, _startPosY + 105 / a, 15 / a, 10 / a);
                g.DrawEllipse(pen1, _startPosX + 140 / a, _startPosY + 80 / a, 15 / a, 10 / a);

                Brush spoiler = new SolidBrush(DopColor);
               
              
                g.FillEllipse(spoiler, _startPosX + 133 / a, _startPosY - 30 / a, 15 / a, 10 / a);
                g.FillEllipse(spoiler, _startPosX + 140 / a, _startPosY - 5 / a, 15 / a, 10 / a);
                g.FillEllipse(spoiler, _startPosX + 140 / a, _startPosY + 20 / a, 15 / a, 10 / a);

                g.FillEllipse(spoiler, _startPosX + 133 / a, _startPosY + 130 / a, 15 / a, 10 / a);
                g.FillEllipse(spoiler, _startPosX + 140 / a, _startPosY + 105 / a, 15 / a, 10 / a);
                g.FillEllipse(spoiler, _startPosX + 140 / a, _startPosY + 80 / a, 15 / a, 10 / a);

            }
            base.DrawPlane(g);
        }        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Bombs + ";" +
           Shoot;
        }
        /// Метод интерфейса IComparable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(BomberPlane other)
        {
            var res = (this is WarPlane).CompareTo(other is WarPlane);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Bombs != other.Bombs)
            {
                return Bombs.CompareTo(other.Bombs);
            }
            if (Shoot != other.Shoot)
            {
                return Shoot.CompareTo(other.Shoot);
            }
            return 0;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(BomberPlane other)
        {
            var res = (this as WarPlane).Equals(other as WarPlane);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Bombs != other.Bombs)
            {
                return false;
            }
         
            if (Shoot != other.Shoot)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is BomberPlane carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
