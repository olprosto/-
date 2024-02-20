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
    /// Логика взаимодействия для Page10.xaml
    /// </summary>
    public partial class Page10 : Page
    {
        public Page10()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TBY.Text) || string.IsNullOrEmpty(TBX.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                    "Задание #10",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                TBX.Text = string.Empty;
                TBY.Text = string.Empty;
            }
            else
            {
                double x = double.Parse(TBX.Text), y = double.Parse(TBY.Text);
                MessageBox.Show($"U = {(Math.Exp(Math.Pow(x, 3)) + Math.Pow(Math.Cos(x - 4), 2)) / (Math.Atan(x) + 5.2 * y)}",
                    "Задание 10", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                TBX.Text = string.Empty;
                TBY.Text = string.Empty;
            }
        }
    }
}
    

