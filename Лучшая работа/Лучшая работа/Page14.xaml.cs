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
    /// Логика взаимодействия для Page14.xaml
    /// </summary>
    public partial class Page14 : Page
    {
        public Page14()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TBX.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                    "Задание #14",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TBX.Text = string.Empty;
                TBY.Text = string.Empty;
            }
            else
            {
                double x = double.Parse(TBX.Text);

                MessageBox.Show($"R = {(Math.Pow(Math.Sin(Math.Pow(x, 2) + 4), 3) + 4.3) / (Math.Pow(Math.Sin(Math.Pow(x, 4)), 3))}",
                    "Задание 14",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                TBX.Text = string.Empty;
                TBY.Text = string.Empty;
            }
        }
    }
}
