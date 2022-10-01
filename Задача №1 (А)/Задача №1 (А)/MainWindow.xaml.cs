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

namespace Задача__1__А_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TrataTb.Clear(); RasstTb.Clear(); PriceTb.Clear(); ResultLb.Content = "";
        }

        private void ExtBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SumBtn_Click(object sender, RoutedEventArgs e)
        {
            double Price = double.Parse(PriceTb.Text); double Rasst = double.Parse(RasstTb.Text); double Rashod = double.Parse(TrataTb.Text); double Result;
            Result = (Rasst / 100) * Rashod * Price;
            if (ToAndHomeCheck.IsChecked == true)
            {
                Result *= 2; ResultLb.Content = Result;
            }
            else
            ResultLb.Content = Result;
        }
    }
}
