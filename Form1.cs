using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SierpinskiCarpet
{
    public partial class Form1 : Form
    {
        // Конструктор форми
        public Form1()
        {
            InitializeComponent();
        }

        // Обробник події натискання кнопки для малювання килиму Серпінського
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            // Отримуємо значення з текстових полів
            int A = int.Parse(textBoxA.Text);
            int B = int.Parse(textBoxB.Text);
            int K = int.Parse(textBoxK.Text);

            // Створюємо новий bitmap для малювання
            Bitmap bitmap = new Bitmap(panelDraw.Width, panelDraw.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Очищаємо фон білим кольором
                g.Clear(Color.White);
                // Малюємо килим Серпінського
                DrawSierpinskiCarpet(g, K, 0, 0, A, B);
            }
            // Встановлюємо намальований килим як фон для панелі
            panelDraw.BackgroundImage = bitmap;
        }

        // Метод для рекурсивного малювання килиму Серпінського
        private void DrawSierpinskiCarpet(Graphics g, int order, int x, int y, int width, int height)
        {
            if (order == 0)
            {
                // Якщо порядок 0, заповнюємо прямокутник чорним кольором
                g.FillRectangle(Brushes.Black, x, y, width, height);
            }
            else
            {
                // Ділимо прямокутник на 9 менших прямокутників
                int w = width / 3;
                int h = height / 3;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i == 1 && j == 1) // центральний фрагмент не заповнюємо
                        {
                            g.FillRectangle(Brushes.White, x + w * i, y + h * j, w, h);
                        }
                        else
                        {
                            // Рекурсивно малюємо килим для інших фрагментів
                            DrawSierpinskiCarpet(g, order - 1, x + w * i, y + h * j, w, h);
                        }
                    }
                }
            }
        }
    }
}
