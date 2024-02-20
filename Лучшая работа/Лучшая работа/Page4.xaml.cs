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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Лучшая_работа
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TBX.Text) || string.IsNullOrEmpty(TBY.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                    "Задание #4",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TBX.Text = string.Empty;
                TBY.Text = string.Empty;
            }
            else
            {
                double x = double.Parse(TBX.Text), y = double.Parse(TBY.Text);

                MessageBox.Show($"L = {(Math.Sqrt(Math.Pow(2 + y, 2) + Math.Sqrt(Math.Sin(y + 5)))) / (Math.Log10(x + 1) - Math.Pow(y, 3))}",
                    "Задание 4",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                TBX.Text = string.Empty;
                TBY.Text = string.Empty;
            }
        }
    }
}
