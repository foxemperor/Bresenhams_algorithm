using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKG_lab01
{
    public partial class Form1 : Form
    {
        static int startPointX, startPointY;
        int x0, x1, y0, y1, a, b;
        private List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region
        //Метод, устанавливающий пиксел на форме с заданными цветом и прозрачностью
        private static void PutPixel(Graphics g, Color col, int x, int y, int alpha)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(alpha, col)), x, y, 1, 1);
        }

        //Статический метод, реализующий отрисовку 4-связной линии по алгоритму Брезенхема
        static public void Bresenham4Line(Graphics g, Color clr, int x0, int y0, int x1, int y1)
        {
            //Изменения координат
            int dx = (x1 > x0) ? (x1 - x0) : (x0 - x1);
            int dy = (y1 > y0) ? (y1 - y0) : (y0 - y1);
            //Направление приращения
            int sx = (x1 >= x0) ? (1) : (-1);
            int sy = (y1 >= y0) ? (1) : (-1);

            if (dy < dx)
            {
                int d = (dy << 1) - dx;
                int d1 = dy << 1;
                int d2 = (dy - dx) << 1;
                PutPixel(g, clr, x0, y0, 255);
                int x = x0 + sx;
                int y = y0;
                for (int i = 1; i <= dx; i++)
                {
                    if (d > 0)
                    {
                        d += d2;
                        y += sy;
                    }
                    else
                        d += d1;
                    PutPixel(g, clr, x, y, 255);
                    x++;
                }
            }
            else
            {
                int d = (dx << 1) - dy;
                int d1 = dx << 1;
                int d2 = (dx - dy) << 1;
                PutPixel(g, clr, x0, y0, 255);
                int x = x0;
                int y = y0 + sy;
                for (int i = 1; i <= dy; i++)
                {
                    if (d > 0)
                    {
                        d += d2;
                        x += sx;
                    }
                    else
                        d += d1;
                    PutPixel(g, clr, x, y, 255);
                    y++;
                }
            }
        }

        //Статический метод, реализующий отрисовку окружности по алгоритму Брезенхема
        public static void BresenhamCircle(Graphics g, Color clr, int _x, int _y, int radius)
        {

            int x = 0, y = radius, gap = 0, delta = (2 - 2 * radius);
            while (y >= 0)
            {
                PutPixel(g, clr, _x + x, _y + y, 255);
                PutPixel(g, clr, _x + x, _y - y, 255);
                PutPixel(g, clr, _x - x, _y - y, 255);
                PutPixel(g, clr, _x - x, _y + y, 255);
                gap = 2 * (delta + y) - 1;
                if (delta < 0 && gap <= 0)
                {
                    x++;
                    delta += 2 * x + 1;
                    continue;
                }
                if (delta > 0 && gap > 0)
                {
                    y--;
                    delta -= 2 * y + 1;
                    continue;
                }
                x++;
                delta += 2 * (x - y);
                y--;
            }
        }

        //Кнопка рисования линии по заданным точкам
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Bresenham4Line(g, Color.Black, Convert.ToInt32(X1.Text), Convert.ToInt32(Y1.Text),
                Convert.ToInt32(X2.Text), Convert.ToInt32(Y2.Text));
        }

        //Кнопка рисования окружности на определенном радиусе от указанной точки
        private void button2_Click(object sender, EventArgs e)
        {

            Graphics g = pictureBox1.CreateGraphics();
            BresenhamCircle(g, Color.Red, Convert.ToInt32(circle_x.Text), Convert.ToInt32(circle_y.Text), Convert.ToInt32(RadiusBox.Text));
        }
        #endregion

        #region
        //Функция Брезенхема для рисования мышью
        void BresenhamLine(int x0, int y0, int x1, int y1)
        {
            if (radioButton1.Checked)
            {
                var gr = pictureBox1.CreateGraphics();
                var steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0); // Проверяем рост отрезка по оси икс и по оси игрек
                                                                   // Отражаем линию по диагонали, если угол наклона слишком большой
                if (steep)
                {
                    Swap(ref x0, ref y0); // Перетасовка координат вынесена в отдельную функцию для красоты
                    Swap(ref x1, ref y1);
                }
                // Если линия растёт не слева направо, то меняем начало и конец отрезка местами
                if (x0 > x1)
                {
                    Swap(ref x0, ref x1);
                    Swap(ref y0, ref y1);
                }
                int dx = x1 - x0;
                int dy = Math.Abs(y1 - y0);
                int error = dx / 2; // Здесь используется оптимизация с умножением на dx, чтобы избавиться от лишних дробей
                int ystep = (y0 < y1) ? 1 : -1; // Выбираем направление роста координаты y
                int y = y0;
                for (int x = x0; x <= x1; x++)
                {
                    DrawPoint(steep ? y : x, steep ? x : y, gr); // Не забываем вернуть координаты на место
                    error -= dy;
                    if (error < 0)
                    {
                        y += ystep;
                        error += dx;
                    }
                }
            }
            
        }

        //Соединяет две точки
        public void DrawPoint(int x, int y, Graphics gr)
        {
            gr.FillRectangle(Brushes.Black, x, y, 1, 1);
        }

        //Переключение координат (конец-начало и начало-конец)
        void Swap(ref int x, ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        //Рисование по клику мышки
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                if (startPointX != 0 && startPointY != 0)
                    BresenhamLine(startPointX, startPointY, e.X, e.Y);

                startPointX = e.X;
                startPointY = e.Y;
            }
        }
        #endregion

        #region
        // Bitmap
        Bitmap pixelBitmap = new Bitmap(800, 600);

        // При движении курсора вниз
        public void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButton2.Checked)
            {
                x0 = e.X;
                y0 = e.Y;
            }

            if (radioButton3.Checked)
            {
                x0 = e.X;
                y0 = e.Y;
            }
        }

        // При движении курсора вверх
        public void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioButton2.Checked)
            {
                Bitmap pixelBitmap1 = new Bitmap(800, 600);// Создаёт пустой битмап
                pixelBitmap = pixelBitmap1; // Присваивает основному свойства пустого
                pictureBox1.Image = pixelBitmap;
                x1 = e.X;
                y1 = e.Y;

                // Отрисовка прямоугольника
                RectangleForEllipse(x0, y0, x1, y1);
                a = Math.Abs(x0 - x1) / 2;
                b = Math.Abs(y0 - y1) / 2;

                DrawEllipse(Math.Abs(x0 - x1), Math.Abs(y0 - y1), a, b);
            }

            if(radioButton3.Checked)
            {
                Bitmap pixelBitmap1 = new Bitmap(800, 600);// Создаёт пустой битмап
                pixelBitmap = pixelBitmap1; // Присваивает основному свойства пустого
                pictureBox1.Image = pixelBitmap;
                x1 = e.X;
                y1 = e.Y;

                // Отрисовка прямоугольника
                DrawRectangle(x0, y0, x1, y1);
                a = Math.Abs(x0 - x1) / 2;
                b = Math.Abs(y0 - y1) / 2;
            }
        }

        // Рисование пикселя для первого квадранта, и, симметрично, для остальных
        void pixel4(int x, int y, int _x, int _y) 
        {
                pixelBitmap.SetPixel(_x + x0 + a, _y + y0 + b, Color.Red);
                pixelBitmap.SetPixel(_x + x0 + a, -_y + y0 + b, Color.Red);
                pixelBitmap.SetPixel(-_x + x0 + a, -_y + y0 + b, Color.Red);
                pixelBitmap.SetPixel(-_x + x0 + a, _y + y0 + b, Color.Red);
                pictureBox1.Image = pixelBitmap;
        }


        // Отрисовка эллипса по Брезенхему
        void DrawEllipse(int x, int y, int a, int b)
        {
            {
                int _x = 0; // Компонента x
                int _y = b; // Компонента y
                int a_sqr = a * a;// a^2, a - большая полуось
                int b_sqr = b * b; // b^2, b - малая полуось
                int delta = 4 * b_sqr * ((_x + 1) * (_x + 1)) + a_sqr * ((2 * _y - 1) * (2 * _y - 1)) - 4 * a_sqr * b_sqr; // Функция координат точки (x+1, y-1/2)
                while (a_sqr * (2 * _y - 1) > 2 * b_sqr * (_x + 1)) // Первая часть дуги
                {
                    pixel4(x, y, _x, _y);
                    // Переход по горизонтали
                    if (delta < 0)
                    {
                        _x++;
                        delta += 4 * b_sqr * (2 * _x + 3);
                    }
                    // Переход по диагонали
                    else
                    {
                        _x++;
                        delta = delta - 8 * a_sqr * (_y - 1) + 4 * b_sqr * (2 * _x + 3);
                        _y--;
                    }
                }
                // Функция координат точки (x+1/2, y-1)
                delta = b_sqr * ((2 * _x + 1) * (2 * _x + 1)) + 4 * a_sqr * ((_y + 1) * (_y + 1)) - 4 * a_sqr * b_sqr;
                // Вторая часть дуги, если не выполняется условие первого цикла, значит выполняется a^2(2y - 1) <= 2b^2(x + 1)
                while (_y + 1 != 0)
                {
                    pixel4(x, y, _x, _y);
                    // Переход по вертикали
                    if (delta < 0)
                    {
                        _y--;
                        delta += 4 * a_sqr * (2 * _y + 3);
                    }
                    // Переход по диагонали
                    else
                    {
                        _y--;
                        delta = delta - 8 * b_sqr * (_x + 1) + 4 * a_sqr * (2 * _y + 3);
                        _x++;
                    }
                }
            }
        }

        // Рисовка прямоугольника, по Брезенхему
        private void DrawRectangle(int xa, int ya, int xb, int yb)
        {

            x1 = Math.Max(xa, xb);
            x0 = Math.Min(xa, xb);
            y1 = Math.Max(ya, yb);
            y0 = Math.Min(ya, yb);
            for (int x = x0; x <= x1; x++)
            {
                pixelBitmap.SetPixel(x, y0, Color.Black);
                pixelBitmap.SetPixel(x, y1, Color.Black);
            }
            for (int y = y0; y <= y1; y++)
            {
                pixelBitmap.SetPixel(x0 - 1, y, Color.Black);
                pixelBitmap.SetPixel(x1 + 1, y, Color.Black);

            }
            pictureBox1.Image = pixelBitmap;
        }

        // Рисовка прямоугольника, по Брезенхему для правильного описания окружности в выделенной области
        private void RectangleForEllipse(int xa, int ya, int xb, int yb)
        {

            x1 = Math.Max(xa, xb);
            x0 = Math.Min(xa, xb);
            y1 = Math.Max(ya, yb);
            y0 = Math.Min(ya, yb);
            for (int x = x0; x <= x1; x++)
            {
                pixelBitmap.SetPixel(x, y0, Color.White);
                pixelBitmap.SetPixel(x, y1, Color.White);
            }
            for (int y = y0; y <= y1; y++)
            {
                pixelBitmap.SetPixel(x0 - 1, y, Color.White);
                pixelBitmap.SetPixel(x1 + 1, y, Color.White);

            }
            pictureBox1.Image = pixelBitmap;
        }

        #endregion

        #region
        private void radioButton1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
