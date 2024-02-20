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
    /// Логика взаимодействия для Page18.xaml
    /// </summary>
    public partial class Page18 : Page
    {
        public Page18()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TBY.Text) || string.IsNullOrEmpty(TBT.Text))
            {
                MessageBox.Show($"ОШИБКА!!!", "Задание #18",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                TBY.Text = string.Empty;
                TBT.Text = string.Empty;
            }
            else
            {
                double y = double.Parse(TBY.Text), t = double.Parse(TBT.Text);
                MessageBox.Show($"S = {(4.351 * Math.Pow(y, 3) + 2 * t * Math.Log10(t)) / (Math.Sqrt(Math.Cos(2 * y) + 4.351))}",
                    "Задание 18", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                TBY.Text = string.Empty; TBT.Text = string.Empty;
            }
        }
    }
}
