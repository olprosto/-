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
    /// Логика взаимодействия для Page21.xaml
    /// </summary>
    public partial class Page21 : Page
    {
        public Page21()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs s)
        {
            if (string.IsNullOrEmpty(TBA.Text) || string.IsNullOrEmpty(TBX.Text) || string.IsNullOrEmpty(TBE.Text))
    {
                MessageBox.Show($"ОШИБКА!!!",
                    "Задание 21",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
                TBE.Text = string.Empty;
            }
            else
            {
                double x = double.Parse(TBX.Text), a = double.Parse(TBA.Text), z = double.Parse(TBE.Text);

                MessageBox.Show($"N = {(Math.Pow(Math.Sqrt(z + Math.Sqrt(z * x)), 5)) / (Math.Exp(x) + Math.Pow(a, 5) * Math.Atan(x))}",
                    "Задание 21",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
                TBE.Text = string.Empty;
            }
        }
    }
}
