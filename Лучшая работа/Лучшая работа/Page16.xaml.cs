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
    /// Логика взаимодействия для Page16.xaml
    /// </summary>
    public partial class Page16 : Page
    {
        public Page16()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TBY.Text) || string.IsNullOrEmpty(TBX.Text) || string.IsNullOrEmpty(TBT.Text))           
            {
                MessageBox.Show($"ОШИБКА!!!", "Задание #16",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                TBX.Text = string.Empty;
                TBY.Text = string.Empty; TBT.Text = string.Empty;
            }
            else
            {
                double x = double.Parse(TBX.Text), y = double.Parse(TBY.Text), t = double.Parse(TBX.Text);
                MessageBox.Show($"P = {(Math.Pow(Math.Sin(x), 3) + Math.Log10(2 * y + 3 * x)) / (Math.Pow(t, 2) + Math.Sqrt(x))}", "Задание 16",
                    MessageBoxButton.OK, MessageBoxImage.Information);

                TBX.Text = string.Empty; TBY.Text = string.Empty;
                TBT.Text = string.Empty;
            }
        }
    }
}
