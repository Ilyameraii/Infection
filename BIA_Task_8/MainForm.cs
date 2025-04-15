using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIA_Task_8
{
    public partial class Form1 : Form
    {
        private int N = 5;
        private int[,] cell = new int[5, 5];
        private const int Healthy = 0; // Здоровая клетка
        private const int Infected = 1; // Зараженная клетка
        private const int Immune = 8; // Невосприимчивая клетка
        private int a = 0; // цифра 4 для таймера
        private int b = 0; // цифра 3 для таймера
        private int c = 0; // цифра 2 для таймера
        private int d = 0; // цифра 1 для таймера
        Random rand = new Random(); //рандом 
        public Form1()
        {
            InitializeComponent();


            int N = Convert.ToInt32(numericUpDownSize.Value); // Размер матрицы N x N
            int PixelSize = panel.Width / N; // Размер одного "пикселя"
            // создаем матрицу из Button
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Button pixel = new Button();
                    pixel.Name = $"pixel{i}{j}";
                    pixel.Size = new Size(PixelSize, PixelSize);
                    pixel.Location = new Point(j * PixelSize, i * PixelSize);
                    pixel.BackColor = Color.White;
                    pixel.FlatStyle = FlatStyle.Flat;
                    pixel.FlatAppearance.BorderSize = 0;
                    pixel.Click += Pixel_Click; // Обработка клика
                    if (i == N / 2 && j == N / 2)
                    {
                        pixel.BackColor = Color.Black;
                    }
                    panel.Controls.Add(pixel);

                }
            }

        }
        // Обработка клика по пикселю
        private void Pixel_Click(object sender, EventArgs e)
        {
            Button pixel = (Button)sender;
            if (pixel.BackColor == Color.White)
            {

                pixel.BackColor = Color.Black; // Меняем цвет пикселя
            }
            else if (pixel.BackColor == Color.Black)
            {

                pixel.BackColor = Color.White; // Меняем цвет пикселя
            }

        }

        private void numericUpDownSize_ValueChanged(object sender, EventArgs e)
        {
            N = Convert.ToInt16(numericUpDownSize.Value); // Размер матрицы N x N
            int PixelSize = panel.Width / N; // Размер одного "пикселя"

            panel.Controls.Clear(); // Очищаем панель перед созданием новых кнопок
            // пересоздаем матрицу из Button
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Button pixel = new Button();
                    pixel.Name = $"pixel{i}{j}";
                    pixel.Size = new Size(PixelSize, PixelSize);
                    pixel.Location = new Point(j * PixelSize, i * PixelSize);
                    pixel.BackColor = Color.White;
                    pixel.FlatStyle = FlatStyle.Flat;
                    pixel.FlatAppearance.BorderSize = 0;
                    pixel.Click += Pixel_Click; // Обработка клика
                    if (i == N / 2 && j == N / 2)
                    {
                        pixel.BackColor = Color.Black;
                    }
                    panel.Controls.Add(pixel);
                }
            }
            // пересоздаем матрицу значений
            cell = new int[N, N];
        }

        private void numericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = Convert.ToInt32(numericUpDownInterval.Value);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
        private void UpdateCellStates()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (cell[i, j] >= Infected && cell[i, j] < Immune)
                    {
                        cell[i, j]++;
                        infection(i, j);
                    }
                    else if (cell[i, j] >= Immune)
                    {
                        // Клетка невосприимчива
                        cell[i, j]++;
                        if (cell[i, j] > Immune + 4)
                        {
                            // Клетка выздоравливает
                            cell[i, j] = Healthy;
                        }
                    }
                }
            }
        }
        private void UpdateCellColors()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    string pixelName = $"pixel{i}{j}";
                    Button pixel = panel.Controls.Find(pixelName, true).FirstOrDefault() as Button;
                    if (cell[i, j] == Healthy)
                    {
                        pixel.BackColor = Color.White;
                    }
                    else if (cell[i, j] >= Infected && cell[i, j] < Immune)
                    {
                        pixel.BackColor = Color.Black;
                    }
                    else if (cell[i, j] >= Immune)
                    {
                        pixel.BackColor = Color.LawnGreen;
                    }
                }
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            // секундомер
            a++;
            if (a > 9)
            {
                a = 0;
                b++;
            }
            if (b > 5)
            {
                b = 0;
                c++;
            }
            if (c > 9)
            {
                c = 0;
                d++;
            }
            if (d > 5)
            {
                d = 0;
            }
            labelTimer.Text = $"{d}{c}:{b}{a}";

            // записываем единицу в матрицу для закрашенных черных элементов
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    string pixelName = $"pixel{i}{j}";
                    Button pixel = panel.Controls.Find(pixelName, true).FirstOrDefault() as Button;
                    if (pixel.BackColor == Color.Black && cell[i, j] < Infected)
                    {
                        cell[i, j] = 1;
                    }
                }
            }
            UpdateCellStates();
            UpdateCellColors();
        }
        private void infection(int i, int j)
        {
            for (int choose = 0; choose < 4; choose++)
            {
                int chance = rand.Next(2);
                if (chance == 0)
                {
                    switch (choose)
                    {
                        case 0:
                            if (i - 1 >= 0)
                            {
                                if (cell[i - 1, j] == Healthy|| (cell[i - 1, j] >=Immune && rand.NextDouble() < Convert.ToDouble(numericUpDownInfection.Value)))
                                {
                                    cell[i - 1, j] = Infected;
                                }
                            }
                            break;
                        case 1:
                            if (j - 1 >= 0)
                            {
                                if (cell[i, j - 1] == Healthy || (cell[i, j - 1] >= Immune && rand.NextDouble() < Convert.ToDouble(numericUpDownInfection.Value)))
                                {
                                    cell[i, j - 1] = Infected;
                                }
                            }
                            break;
                        case 2:
                            if (i + 1 < N)
                            {
                                if (cell[i + 1, j] == Healthy || (cell[i + 1, j] >= Immune && rand.NextDouble() < Convert.ToDouble(numericUpDownInfection.Value)))
                                {
                                    cell[i + 1, j] = Infected;
                                }
                            }
                            break;
                        case 3:
                            if (j + 1 < N)
                            {
                                if (cell[i, j + 1] == Healthy || (cell[i, j + 1] >= Immune && rand.NextDouble() < Convert.ToDouble(numericUpDownInfection.Value)))
                                {
                                    cell[i, j + 1] = Infected;
                                }
                            }
                            break;
                    }
                }
            }

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
