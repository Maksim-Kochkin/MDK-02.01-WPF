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

namespace Задача__1__В_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Type(); Size(); Topings();
            Result();
        }

        private void ResultTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public void Type()
        {

        }
        public void Size()
        {

        }
        public void Topings()
        {

        }
        public void Result()
        {
            int Result = 0; string Res = Convert.ToString(Result);
            ResultTb.Text = Res;
        }
    }
}
