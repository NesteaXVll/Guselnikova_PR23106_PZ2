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
    /// Логика взаимодействия для Task1.xaml
    /// </summary>
    public partial class Task1 : Window
    {
        public Task1()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int n;
            if (int.TryParse(txtInput.Text, out n) && n <= 1000 && n >= 0)
            {
                double result = Math.Pow(n, n);
                string resultString = result.ToString();
                int[] digitCounts = new int[10];
                foreach (char digit in resultString)
                {
                    if (char.IsDigit(digit))
                    {
                        digitCounts[digit - '0']++;
                    }
                }
                string output = "Повторения цифр:\n";
                for (int i = 0; i < 10; i++)
                {
                    if (digitCounts[i] > 0)
                    {
                        output += $"{i}: {digitCounts[i]} раз(а)\n";
                    }
                }
                txtResult.Text = output;
            }
            else
            {
                txtResult.Text = "Число введено некорректно или >1000";
            }
        }
    }
}
