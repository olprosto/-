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
    /// Логика взаимодействия для Page17.xaml
    /// </summary>
    public partial class Page17 : Page
    {
        public Page17()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs s)
        {
            if (string.IsNullOrEmpty(TBA.Text) || string.IsNullOrEmpty(TBX.Text) || string.IsNullOrEmpty(TBE.Text) || string.IsNullOrEmpty(TBY.Text))
    {
                MessageBox.Show($"ОШИБКА!!!",
                    "Задание 17",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
                TBE.Text = string.Empty;
                TBY.Text = string.Empty;
            }
    else
            {
                double x = double.Parse(TBX.Text), a = double.Parse(TBA.Text), b = double.Parse(TBE.Text), y = double.Parse(TBY.Text);

                MessageBox.Show($"T = {(Math.Sqrt(x + b - a) + Math.Log10(y)) / (Math.Atan(b + a))}",
                    "Задание 17",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
                TBE.Text = string.Empty;
                TBY.Text = string.Empty;
            }
        }
    }
}
