using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sem3TecPr1
{
    public partial class FormTractor : Form
    {
        private Tractor tractor;

        /// <summary>         
        /// Конструктор         
        /// </summary> 
        public FormTractor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод отрисовки машины
        /// </summary> 
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTractors.Width, pictureBoxTractors.Height);
            Graphics gr = Graphics.FromImage(bmp);
            tractor.DrawTractor(gr);
            pictureBoxTractors.Image = bmp;
        }

        /// <summary> 
        /// Обработка нажатия кнопки "Создать"         
        /// </summary>         
        /// <param name="sender"></param>         
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tractor = new Tractor(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow);
            tractor.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTractors.Width, pictureBoxTractors.Height);
            Draw();
        }

        /// <summary>         
        /// Обработка нажатия кнопок управления         
        /// </summary>         
        /// <param name="sender"></param>        
        /// <param name="e"></param>        
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки           
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    tractor.MoveTransport(Tractor.Direction.Up);
                    break;
                case "buttonDown":
                    tractor.MoveTransport(Tractor.Direction.Down);
                    break;
                case "buttonLeft":
                    tractor.MoveTransport(Tractor.Direction.Left);
                    break;
                case "buttonRight":
                    tractor.MoveTransport(Tractor.Direction.Right);
                    break;
            }
            Draw();
        }   
    }
}
