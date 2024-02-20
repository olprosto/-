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
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs s)
        {
            if (string.IsNullOrEmpty(TBA.Text) || string.IsNullOrEmpty(TBX.Text) || string.IsNullOrEmpty(TBE.Text))
     {
                MessageBox.Show($"ОШИБКА!!!",
                    "Задание 7",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
                TBE.Text = string.Empty;
            }
     else
            {
                double x = double.Parse(TBX.Text), y = double.Parse(TBA.Text), a = double.Parse(TBE.Text);

                MessageBox.Show($"G = {(Math.Cos(Math.Pow(x, 3) + 6) - Math.Sin(y - a)) / (Math.Log10(Math.Pow(x, 4)) - 2 * Math.Pow(Math.Sin(x), 5))}",
                    "Задание 7",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
                TBE.Text = string.Empty;
            }
        }
    }
}
