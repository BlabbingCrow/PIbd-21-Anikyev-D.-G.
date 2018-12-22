using System;
using System.Drawing;

namespace Sem3TecPr1
{
    /// <summary>     
    /// Класс отрисовки автомобиля     
    /// </summary> 
    public class Tractor : TractorBase, IComparable<Tractor>, IEquatable<Tractor>
    {
        /// <summary>         
        /// Дополнительный цвет         
        /// </summary>         
        public Color DopColor { private set; get; }

        /// <summary>         
        /// Признак наличия переднего спойлера         
        /// </summary>         
        public bool FrontEquipment { private set; get; } 

        /// <summary>         
        /// Признак наличия заднего спойлера         
        /// </summary>         
        public bool BackEquipment { private set; get; } 

        /// <summary>         
        /// Конструктор         
        /// </summary>         
        /// <param name="maxSpeed">Максимальная скорость</param>         
        /// <param name="weight">Вес автомобиля</param>         
        /// <param name="mainColor">Основной цвет кузова</param>       
        /// <param name="dopColor">Дополнительный цвет</param>         
        public Tractor(int maxSpeed, float weight, Color mainColor, Color dopColor, bool frontEquipment, bool backEquipment) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            FrontEquipment = frontEquipment;
            BackEquipment = backEquipment;
        }

        public Tractor(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                FrontEquipment = Convert.ToBoolean(strs[4]);
                BackEquipment = Convert.ToBoolean(strs[5]);
            }
        }


        public override void DrawTractor(Graphics g)
        {
            SolidBrush br = new SolidBrush(DopColor);
            Pen pen = new Pen(Color.Black);
            // отрисуем сперва переднее оборудование автомобиля           
            if (FrontEquipment)
            {
                Point[] points = new Point[3];
                points[0] = new Point((int)_startPosX + 103, (int)_startPosY + 35);
                points[1] = new Point((int)_startPosX + 113, (int)_startPosY + 10);
                points[2] = new Point((int)_startPosX + 123, (int)_startPosY + 50);
                g.FillPolygon(br, points);
                g.DrawPolygon(pen, points);
            }
            // рисуем заднее оборудование автомобиля       
            if (BackEquipment)
            {
                Point[] points = new Point[4];
                points[0] = new Point((int)_startPosX + 25, (int)_startPosY + 35);
                points[1] = new Point((int)_startPosX + 10, (int)_startPosY + 30);
                points[2] = new Point((int)_startPosX, (int)_startPosY + 50);
                points[3] = new Point((int)_startPosX + 10, (int)_startPosY + 40);
                g.FillPolygon(br, points);
                g.DrawPolygon(pen, points);
            }

            // теперь отрисуем основной кузов автомобиля 
            base.DrawTractor(g);

            // рисуем гоночные полоски       
            g.FillRectangle(br, _startPosX + 55, _startPosY + 25, 45, 5);
        }

        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + FrontEquipment + ";" + BackEquipment;
        }

        /// <summary>
        /// Метод интерфейса IComparable для класса Tractor
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Tractor other)
        {
            var res = (this is TractorBase).CompareTo(other is TractorBase);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                return DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (FrontEquipment != other.FrontEquipment)
            {
                return FrontEquipment.CompareTo(other.FrontEquipment);
            }
            if (BackEquipment != other.BackEquipment)
            {
                return BackEquipment.CompareTo(other.BackEquipment);
            }
            return 0;
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса Tractor
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Tractor other)
        {
            var res = (this as TractorBase).Equals(other as TractorBase);
            if (!res)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (FrontEquipment != other.FrontEquipment)
            {
                return false;
            }
            if (BackEquipment != other.BackEquipment)
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
            Tractor tractorObj = obj as Tractor;
            if (tractorObj == null)
            {
                return false;
            }
            else
            {
                return Equals(tractorObj);
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
