﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3TecPr1
{
    /// <summary>
    /// Класс-ошибка "Если место, на которое хотим поставить автомобиль уже занято"
    /// </summary>
    public class ParkingOccupiedPlaceException : Exception
    {
        public ParkingOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит автомобиль")
        { }
    }
}
