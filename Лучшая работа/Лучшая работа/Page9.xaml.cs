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
    /// Логика взаимодействия для Page9.xaml
    /// </summary>
    public partial class Page9 : Page
    {
        public Page9()
        {
            InitializeComponent();
        }
        private void BtnTask14_Click(Object sender, RoutedEventArgs s)
        {
            if (string.IsNullOrEmpty(TBA.Text) || string.IsNullOrEmpty(TBX.Text) || string.IsNullOrEmpty(TBE.Text))
     {
                MessageBox.Show($"ОШИБКА!!!",
                    "Задание 9",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
                TBE.Text = string.Empty;
            }
     else
            {
                double x = double.Parse(TBX.Text), y = double.Parse(TBA.Text), d = double.Parse(TBE.Text);

                MessageBox.Show($"R = {(Math.Pow(Math.Cos(y), 3) + Math.Pow(2, x) * d) / (Math.Exp(y) + Math.Log10(Math.Pow(Math.Sin(x), 2) + 7.4))}",
                    "Задание 9",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                TBX.Text = string.Empty;
                TBA.Text = string.Empty;
                TBE.Text = string.Empty;
            }
        }
    }
}
