using NLog;
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
        /// <summary>
        /// Объект от класса многоуровневой парковки
        /// </summary>
        MultiLevelParking parking;
       
        FormPlaneConfig form;
        private const int countLevel = 5;
        private Logger logger;
        public FormParking()

        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width,
            pictureBoxParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
                pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        private void ButtonTakePlane_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    try
                    {
                        var plane = parking[listBoxLevels.SelectedIndex] -
                        Convert.ToInt32(maskedTextBox.Text);
                        Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width,
                        pictureBoxTakePlane.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        plane.SetPosition(15, 15, pictureBoxTakePlane.Width,
                        pictureBoxTakePlane.Height);
                        plane.DrawPlane(gr);
                        pictureBoxTakePlane.Image = bmp;
                        logger.Info("Изъят самолет " + plane.ToString() + " с места " + maskedTextBox.Text);
                        Draw();

                    }
                    catch (ParkingNotFoundException ex)
                    {
                        logger.Error("Не найден самолет");
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width,
                                      pictureBoxTakePlane.Height);
                        pictureBoxTakePlane.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        logger.Error("Неизвестная ошибка");
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw(); 
        }

        private void ListBoxLevels_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Draw();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            form = new FormPlaneConfig();
            form.AddEvent(AddPlane);
            form.Show();
        }
        private void AddPlane(ITransport plane)
        {
            if (plane != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = parking[listBoxLevels.SelectedIndex] + plane;
                    logger.Info("Добавлен автомобиль " + plane.ToString() + " на место " + place);               
                    Draw();
                    
                }
                catch (ParkingOverflowException ex)
                {
                    logger.Error("Переполнение данным объектом ");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (ParkingAlreadyHaveException ex)
                {
                    
                MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error("Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Error("неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    logger.Error("Место занято");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error("неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void Button_sort_Click(object sender, EventArgs e)
        {
            parking.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }

}
