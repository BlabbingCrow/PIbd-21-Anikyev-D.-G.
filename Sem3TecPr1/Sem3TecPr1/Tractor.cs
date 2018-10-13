using System.Drawing;

namespace Sem3TecPr1
{
    /// <summary>     
    /// Класс отрисовки автомобиля     
    /// </summary> 
    public class Tractor : TractorBase
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
    }
}
