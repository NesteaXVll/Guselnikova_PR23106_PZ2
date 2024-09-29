using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Guselnikova_PR23106_PZ2
{
    /// <summary>
    /// Логика взаимодействия для Task4.xaml
    /// </summary>
    public partial class Task4 : Window
    {
        public Task4()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void BtnRearrange_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;
            int[] numbers = Array.ConvertAll(input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            int totalSum = numbers.Sum();
            int halfSum = totalSum / 2;

            int[] part1 = new int[numbers.Length];
            int[] part2 = new int[numbers.Length];
            int sum1 = 0, sum2 = 0;

            Array.Sort(numbers);

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (sum1 <= sum2)
                {
                    sum1 += numbers[i];
                    part1[numbers.Length - 1 - i] = numbers[i]; 
                }
                else
                {
                    sum2 += numbers[i];
                    part2[numbers.Length - 1 - i] = numbers[i]; 
                }
            }

            double ratio = (double)Math.Max(sum1, sum2) / Math.Min(sum1, sum2);
            if (ratio <= 1.5)
            {
                string result = $"Часть 1: {string.Join(", ", part1.Where(x => x != 0))}\n" +
                                $"Часть 2: {string.Join(", ", part2.Where(x => x != 0))}\n" +
                                $"Сумма 1: {sum1}, Сумма 2: {sum2}";
                txtResult.Text = result;
            }
            else
            {
                txtResult.Text = "Невозможно разделить массив с заданными условиями.";
            }
        }
    }
}
