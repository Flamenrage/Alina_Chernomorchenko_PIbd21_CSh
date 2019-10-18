using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plane_project
{
    public partial class FormParking : Form
       
    {
        Parking<ITransport> parking;
        public FormParking()
        {
           
            InitializeComponent();
            parking = new Parking<ITransport>(20, pictureBoxParking.Width,
     pictureBoxParking.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        private void ButtonSetPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new WarPlane(100, 1000, dialog.Color);
                int place = parking + plane;
                Draw();
            }
        }

        private void ButtonSetBomberPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new BomberPlane(100, 1000, dialog.Color, dialogDop.Color,
                   true, true);
                    int place = parking + plane;
                    Draw();
                }
            }
        }

        private void ButtonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBox.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width,
                   pictureBoxTakePlane.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(15, 15, pictureBoxTakePlane.Width,
                   pictureBoxTakePlane.Height);
                    car.DrawPlane(gr);
                    pictureBoxTakePlane.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width,
                   pictureBoxTakePlane.Height);
                    pictureBoxTakePlane.Image = bmp;
                }
                Draw();
            }
        }
    }
}
