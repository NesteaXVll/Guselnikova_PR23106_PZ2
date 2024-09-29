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
    /// Логика взаимодействия для Task3.xaml
    /// </summary>
    public partial class Task3 : Window
    {
        public Task3()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
            private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;
            string[] elements = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = Array.ConvertAll(elements, int.Parse);

            Dictionary<int, int> countDict = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                if (countDict.ContainsKey(number))
                {
                    countDict[number]++;
                }
                else
                {
                    countDict[number] = 1;
                }
            }

            int maxCount = countDict.Values.Max();

            txtResult.Text = $"Максимальное количество одинаковых элементов: {maxCount}";
        }
    }
}
