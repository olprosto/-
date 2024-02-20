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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs s)
        {
            if (string.IsNullOrEmpty(TBA.Text) || string.IsNullOrEmpty(TBX.Text) || string.IsNullOrEmpty(TBE.Text) || string.IsNullOrEmpty(TBC.Text))
     {
                MessageBox.Show($"ОШИБКА!!!",
                    "Задание 5",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
                TBE.Text = string.Empty;
                TBC.Text = string.Empty;
            }
     else
            {
                double x = double.Parse(TBX.Text), y = double.Parse(TBA.Text), z = double.Parse(TBE.Text), c = double.Parse(TBC.Text);

                MessageBox.Show($"G = {(Math.Tan(Math.Pow(x, 4) - 6) - Math.Pow(Math.Cos(z + x * y), 3)) / (Math.Pow(Math.Cos(Math.Pow(x, 3)), 4) * Math.Pow(c, 2))}",
                    "Задание 5",
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
