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
    /// Логика взаимодействия для Page15.xaml
    /// </summary>
    public partial class Page15 : Page
    {
        public Page15()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs s)
        {
            if (string.IsNullOrEmpty(TBA.Text) || string.IsNullOrEmpty(TBX.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                    "Задание 15",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
            }
            else
            {
                double y = double.Parse(TBX.Text), m = double.Parse(TBA.Text);

                MessageBox.Show($"N = {(Math.Pow(m, 2) + 2.8 * m + 0.355) / (Math.Cos(2 * y) + 3.6)}",
                    "Задание 15",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
            }
        }
    }
}
