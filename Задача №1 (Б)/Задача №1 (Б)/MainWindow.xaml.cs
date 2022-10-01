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

namespace Задача__1__Б_
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

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            GrammTb.Clear(); ResultTb.Clear();
        }

        private void FountRb_Checked(object sender, RoutedEventArgs e) //Фунты
        {
            double Gramm = double.Parse(GrammTb.Text); double Funt;
            Funt = Gramm / 454; string Result = Convert.ToString(Funt); ResultTb.Text = Result;
        }

        private void PoutRb_Checked(object sender, RoutedEventArgs e) //Пуды
        {
            double Gramm = double.Parse(GrammTb.Text); double Pud;
            Pud = Gramm / 16380; string Result = Convert.ToString(Pud); ResultTb.Text = Result;
        }

        private void UnciaRB_Checked(object sender, RoutedEventArgs e) //Унции
        {
            double Gramm = double.Parse(GrammTb.Text); double Ucia;
            Ucia = Gramm / 28.35; string Result = Convert.ToString(Ucia); ResultTb.Text = Result;
        }

        private void DrahmaRB_Checked(object sender, RoutedEventArgs e) //Драхмы
        {
            double Gramm = double.Parse(GrammTb.Text); double Drah;
            Drah = Gramm / 1.772; string Result = Convert.ToString(Drah); ResultTb.Text = Result;
        }

        private void GranRB_Checked(object sender, RoutedEventArgs e) //Граны
        {
            double Gramm = double.Parse(GrammTb.Text); double Gran;
            Gran = Gramm / 0.0648; string Result = Convert.ToString(Gran); ResultTb.Text = Result;
        }
    }
}
