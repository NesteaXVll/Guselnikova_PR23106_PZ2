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
    /// Логика взаимодействия для Task5.xaml
    /// </summary>
    public partial class Task5 : Window
    {
        private int[,] array; 

        public Task5()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtRows.Text, out int rows) && int.TryParse(txtColumns.Text, out int columns))
            {
                array = new int[rows, columns]; 
                Random random = new Random();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = random.Next(-10, 11);
                    }
                }

                DisplayArray(txtOriginalArray, array);

                int[] flatArray = array.Cast<int>().ToArray();
                Array.Sort(flatArray);
                DisplaySortedArray(txtSortedAscending, flatArray);
                Array.Sort(flatArray, (a, b) => b.CompareTo(a));
                DisplaySortedArray(txtSortedDescending, flatArray);

                int min = flatArray.Min();
                int max = flatArray.Max();
                txtMinMax.Text = $"Минимум: {min}, Максимум: {max}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные размеры массива.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DisplayArray(TextBlock textBlock, int[,] array)
        {
            textBlock.Text = string.Empty;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    textBlock.Text += $"{array[i, j]} ";
                }
                textBlock.Text += Environment.NewLine;
            }
        }

        private void DisplaySortedArray(TextBlock textBlock, int[] array)
        {
            textBlock.Text = string.Join(" ", array);
        }
    }
}