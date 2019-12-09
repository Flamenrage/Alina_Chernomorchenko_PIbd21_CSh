using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plane_project
{
    public class Parking<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Parking<T>>
        where T : class, ITransport
    {

        private Dictionary<int, T> _places;
        private int _maxCount;
        private int PictureWidth { get; set; }
       
        private int PictureHeight { get; set; }

        private const int _placeSizeWidth = 210;
        
        private const int _placeSizeHeight = 80;
      
        private int _currentIndex;
        /// <summary>
        /// Получить порядковое место на парковке
        /// </summary>
        public int GetKey
        {
            get
            {
                return _places.Keys.ToList()[_currentIndex];
            }
        }
        public Parking(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            _currentIndex = -1;
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            
        }
        
        public static int operator +(Parking<T> p, T car)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new ParkingOverflowException();
            }
            if (p._places.ContainsValue(car))
            {
                throw new ParkingAlreadyHaveException();
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, car);
                    p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5,
                     i % 5 * _placeSizeHeight + 15, p.PictureWidth,
                    p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T car = p._places[index];
                p._places.Remove(index);
                return car;
            }
            throw new ParkingNotFoundException(index);           
        }
        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            foreach (var plane in _places)
            {
                plane.Value.DrawPlane(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы праковки
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 5; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                throw new ParkingNotFoundException(ind);
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5
                    * _placeSizeHeight + 15, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new ParkingOccupiedPlaceException(ind);
                }
            }
        }
        /// комментарий:
        /// Метод интерфейса IEnumerator для получения текущего элемента
        /// </summary>
        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для получения текущего элемента
        /// </summary>
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        /// Метод интерфейса IEnumerator, вызываемый при удалении объекта
        /// </summary>
        public void Dispose()
        {
            _places.Clear();
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        /// </summary>
        public void Reset()
        {
            _currentIndex = -1;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        /// <summary>
        /// Метод интерфейса IComparable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Parking<T> other)
        {
            if (_places.Count > other._places.Count)
            {
                return -1;
            }
            else if (_places.Count < other._places.Count)
                
             {
                return 1;
            }
            else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; ++i)
                {
                    if (_places[thisKeys[i]] is WarPlane && other._places[thisKeys[i]] is
                   BomberPlane)
                    {
                        return 1;
                    }
                    if (_places[thisKeys[i]] is BomberPlane && other._places[thisKeys[i]]
                    is WarPlane)
                    {
                        return -1;
                    }
                    if (_places[thisKeys[i]] is WarPlane && other._places[thisKeys[i]] is
                    WarPlane)
                    {
                        return (_places[thisKeys[i]] is
                       WarPlane).CompareTo(other._places[thisKeys[i]] is WarPlane);
                    }
                    if (_places[thisKeys[i]] is BomberPlane && other._places[thisKeys[i]]
                    is BomberPlane)
                    {
                        return (_places[thisKeys[i]] is
                       BomberPlane).CompareTo(other._places[thisKeys[i]] is BomberPlane);
                    }
                }
            }
            return 0;
        }
    }
}
