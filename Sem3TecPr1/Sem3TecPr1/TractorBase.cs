using System;
using System.Drawing;

namespace Sem3TecPr1
{
    public class TractorBase : Vehicle, IComparable<TractorBase>, IEquatable<TractorBase>
    {
        /// <summary>         
        /// Ширина отрисовки автомобиля         
        /// </summary>         
        protected const int carWidth = 123;

        /// <summary>         
        /// Ширина отрисовки автомобиля         
        /// </summary>         
        protected const int carHeight = 55;

        /// <summary>         
        /// Конструктор         
        /// </summary>         
        /// <param name="maxSpeed">Максимальная скорость</param>         
        /// <param name="weight">Вес автомобиля</param>         
        /// <param name="mainColor">Основной цвет кузова</param>         
        public TractorBase(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public TractorBase()
        {

        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public TractorBase(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо                 
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево               
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх          
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз      
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawTractor(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            // теперь отрисуем основной кузов автомобиля   
            //границы автомобиля         
            g.DrawEllipse(pen, _startPosX + 20, _startPosY + 20, 30, 30);
            g.DrawEllipse(pen, _startPosX + 90, _startPosY + 30, 20, 20);
            g.DrawEllipse(pen, _startPosX + 100, _startPosY + 15, 5, 10);
            g.DrawRectangle(pen, _startPosX + 25, _startPosY, 35, 20);
            g.DrawRectangle(pen, _startPosX + 25, _startPosY + 20, 75, 20);
            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 5, 5, 15);

            //кузов       
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX + 25, _startPosY, 35, 20);
            g.FillRectangle(br, _startPosX + 25, _startPosY + 20, 75, 20);
            g.FillRectangle(br, _startPosX + 25, _startPosY - 3, 40, 3);

            //труба
            Brush brGray = new SolidBrush(Color.Gray);
            g.FillRectangle(brGray, _startPosX + 80, _startPosY + 5, 5, 15);

            //задние фары            
            Brush brRed = new SolidBrush(Color.Red);
            g.FillRectangle(brRed, _startPosX + 25, _startPosY + 10, 10, 10);

            //передние фары       
            Brush brYellow = new SolidBrush(Color.Yellow);
            g.FillEllipse(brYellow, _startPosX + 100, _startPosY + 15, 5, 10);

            //стекла         
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 37, _startPosY + 1, 23, 18);

            //колеса
            Brush brBlack = new SolidBrush(Color.Black);
            g.FillEllipse(brBlack, _startPosX + 20, _startPosY + 20, 30, 30);
            g.FillEllipse(brBlack, _startPosX + 90, _startPosY + 30, 20, 20);
            g.FillEllipse(brGray, _startPosX + 25, _startPosY + 25, 20, 20);
            g.FillEllipse(brGray, _startPosX + 95, _startPosY + 35, 10, 10);
        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

        /// <summary>
        /// Метод интерфейса IComparable для класса Car
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(TractorBase other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                return MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса TractorBase
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(TractorBase other)
        {
            if (other == null)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
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
            TractorBase tractorObj = obj as TractorBase;
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
