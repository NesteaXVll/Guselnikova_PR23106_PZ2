using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для Task2.xaml
    /// </summary>
    public partial class Task2 : Window
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void BtnTransform_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;

            if (!string.IsNullOrWhiteSpace(input))
            {
                string result = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
                txtResult.Text = result;
            }
            else
            {
                txtResult.Text = "Введите корректную строку!";
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
