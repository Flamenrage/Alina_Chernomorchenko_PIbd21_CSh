using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plane_project
{
    public class ParkingOverflowException : Exception    {
        /// <summary>
        /// Класс-ошибка "Если на парковке уже заняты все места"
        /// </summary>
        public ParkingOverflowException() : base("На парковке нет свободных мест")
        { }
    }
}
