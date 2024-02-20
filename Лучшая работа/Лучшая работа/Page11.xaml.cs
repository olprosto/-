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
    /// Логика взаимодействия для Page11.xaml
    /// </summary>
    public partial class Page11 : Page
    {
        public Page11()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TBY.Text) || string.IsNullOrEmpty(TBX.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                    "Задание #11",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TBX.Text = string.Empty;
                TBY.Text = string.Empty;
            }
            else
            {
                double x = double.Parse(TBX.Text), y = double.Parse(TBY.Text);

                MessageBox.Show($"I = {(2.33 * Math.Log10(Math.Sqrt(1 + Math.Pow(Math.Cos(y), 2)))) / (Math.Exp(y) + Math.Pow(Math.Sin(x), 2))}",
                    "Задание 11",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                TBX.Text = string.Empty;
                TBY.Text = string.Empty;
            }
        }
    }
}
