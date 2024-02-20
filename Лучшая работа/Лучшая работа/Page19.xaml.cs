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
    /// Логика взаимодействия для Page19.xaml
    /// </summary>
    public partial class Page19 : Page
    {
        public Page19()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs s)
        {
            if (string.IsNullOrEmpty(TBA.Text) || string.IsNullOrEmpty(TBX.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                    "Задание #19",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
            }
            else
            {
                double y = double.Parse(TBX.Text), h = double.Parse(TBA.Text);

                MessageBox.Show($"A = {(Math.Tan(Math.Pow(y, 3) - Math.Pow(h, 4)) + Math.Pow(h, 2)) / (Math.Pow(Math.Sin(h), 3) + y)}",
                    "Задание 19",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
            }
        }
    }
}
