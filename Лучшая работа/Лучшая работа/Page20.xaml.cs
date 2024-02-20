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
    /// Логика взаимодействия для Page20.xaml
    /// </summary>
    public partial class Page20 : Page
    {
        public Page20()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TBY.Text) || string.IsNullOrEmpty(TBX.Text) || string.IsNullOrEmpty(TBA.Text) || string.IsNullOrEmpty(TBB.Text) || string.IsNullOrEmpty(TBC.Text))            {
                MessageBox.Show($"ОШИБКА!!!", "Задание #20",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                TBY.Text = string.Empty;
                TBX.Text = string.Empty; TBA.Text = string.Empty;
                TBB.Text = string.Empty; TBC.Text = string.Empty;
            }
            else
            {
                double x = double.Parse(TBX.Text), y = double.Parse(TBY.Text), a = double.Parse(TBA.Text), b = double.Parse(TBB.Text), c = double.Parse(TBC.Text);
                MessageBox.Show($"S = {(Math.Pow(Math.Tan(y), 3) + Math.Pow(Math.Sin(x), 5) * Math.Sqrt(b - c)) / (Math.Sqrt(a - b + c))}",
                    "Задание 20", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                TBY.Text = string.Empty; TBX.Text = string.Empty;
                TBA.Text = string.Empty; TBB.Text = string.Empty;
                TBC.Text = string.Empty;
            }
        }
    }
}
