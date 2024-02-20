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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TBX.Text) || string.IsNullOrEmpty(TBC.Text) || string.IsNullOrEmpty(TBT.Text)) 
            {
                MessageBox.Show($"ОШИБКА!!!",
                    "Задание #2",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TBX.Text = string.Empty;
                TBC.Text = string.Empty;
                TBT.Text = string.Empty;
            }
            else
            {
                double x = double.Parse(TBX.Text), t = double.Parse(TBT.Text), c = double.Parse(TBC.Text);

                MessageBox.Show($"L = {Math.Pow(Math.Tan(1 / c), 2) + (2 * Math.Pow(x, 2) + 5) / Math.Sqrt(c + t)}",
                    "Задание 2",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                TBX.Text = string.Empty;
                TBC.Text = string.Empty;
                TBT.Text = string.Empty;
            }
        }
    }
}
