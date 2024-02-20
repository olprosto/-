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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs s)
        {
            if (string.IsNullOrEmpty(TBA.Text) || string.IsNullOrEmpty(TBX.Text) || string.IsNullOrEmpty(TBE.Text) || string.IsNullOrEmpty(TBC.Text))
     {
                MessageBox.Show($"ОШИБКА!!!",
                    "Задание #1",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
                TBE.Text = string.Empty;
                TBC.Text = string.Empty;
            }
     else
            {
                double x = double.Parse(TBX.Text), a = double.Parse(TBA.Text), e = double.Parse(TBE.Text), c = double.Parse(TBC.Text);

                MessageBox.Show($"L = {(Math.Sqrt(Math.Exp(x) - Math.Pow(Math.Cos(Math.Pow(x, 2) * Math.Pow(a, 5)), 4) + Math.Pow(Math.Atan(a - Math.Pow(x, 5)), 4) / (e * Math.Sqrt(Math.Abs(a + x * Math.Pow(c, 4))))))}",
                    "Задание 1",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
                TBE.Text = string.Empty;
                TBC.Text = string.Empty;
            }
        }
    }
}
