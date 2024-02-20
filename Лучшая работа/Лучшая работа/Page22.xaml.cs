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
    /// Логика взаимодействия для Page22.xaml
    /// </summary>
    public partial class Page22 : Page
    {
        public Page22()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TBY.Text) || string.IsNullOrEmpty(TBX.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                    "Задание #22", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                TBY.Text = string.Empty; TBX.Text = string.Empty;
            }
            else
            {
                double x = double.Parse(TBX.Text), y = double.Parse(TBY.Text);
                MessageBox.Show($"F = {Math.Cos(Math.Pow(x, 2) + 2) + (3.5 * Math.Pow(x, 2) + 1) / (Math.Pow(Math.Cos(y), 2))}", "Задание 22",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                TBY.Text = string.Empty;
                TBX.Text = string.Empty;
            }
        }
    }
}
