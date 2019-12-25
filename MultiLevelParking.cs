using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plane_project
{
    class MultiLevelParking
    {
        /// <summary>
        /// Список с уровнями парковки
        /// </summary>
        List<Parking<ITransport>> parkingStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>

        private const int countPlaces = 15;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй парковки</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int pictureHeight;
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        foreach (ITransport plane in level) { 
                    
                            if (plane != null)
                            {
                                if (plane.GetType().Name == "WarPlane")
                                {
                                    sw.Write(i + ":WarPlane:");
                                }
                                if (plane.GetType().Name == "BomberPlane")
                                {
                                    sw.Write(i + ":BomberPlane:");
                                }
                                sw.WriteLine(plane);
                            }
                        }
                    }
                }
            }
        }
     
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string buffer = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                if ((buffer = sr.ReadLine()).Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(buffer.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>(count);
                }
                else
                {
                    throw new Exception("Неверный формат файла");
                }
                int counter = -1;
                int counterPlane = 0;
                ITransport plane = null;
                while ((buffer = sr.ReadLine()) != null)
                {
                    if (buffer == "Level")
                    {
                        counter++;
                        counterPlane = 0;
                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(buffer))
                    {
                        continue;
                    }
                    if (buffer.Split(':')[1] == "WarPlane")
                    {
                        Console.WriteLine(buffer.Split(':')[2]);
                        plane = new WarPlane(buffer.Split(':')[2]);
                    }
                    else if (buffer.Split(':')[1] == "BomberPlane")
                    {
                        plane = new BomberPlane(buffer.Split(':')[2]);
                    }
                    parkingStages[counter][counterPlane++] = plane;
                }
            }
            return true;
        }
        public void Sort()
        {
            parkingStages.Sort();
        }
    }
}