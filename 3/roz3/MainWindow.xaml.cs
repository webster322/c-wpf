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

namespace roz3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtBok_TextChanged(object sender, TextChangedEventArgs e)
        {
            double bok;
            if(double.TryParse(txtBok.Text, out bok) && bok >= 0)
            {
                txtPole.Text = Math.Pow(bok, 2.0).ToString();
                txtObwod.Text = (bok * 4).ToString();
                lblKomunikat.Content = String.Empty;
            }
            else
            {
                lblKomunikat.Content = "Wpisz liczbę dodatnią";
            }
        }

        private void btnWyczysc_Click(object sender, RoutedEventArgs e)
        {
            txtBok.Text = String.Empty;
            txtPole.Text = String.Empty;
            txtObwod.Text = String.Empty;
            lblKomunikat.Content = "Wpisz wymiar boku";
        }

        private void btnRysuj_Click(object sender, RoutedEventArgs e)
        {
            double bok;
            if (double.TryParse(txtBok.Text, out bok) && bok <= 380)
            {
                rectangle1.Height = bok;
                rectangle1.Width = bok;
                SolidColorBrush color = (SolidColorBrush)new BrushConverter().ConvertFromString(cmbKolory.Text);
                rectangle1.Stroke = color;
                rectangle1.Fill = color;
                rectangle1.Opacity = (cbPrzezroczysty.IsChecked.Value) ? 0.5 : 1;
            }
            else
            {
                lblKomunikat.Content = "Brak danych lub zbyt duży bok";
            }
        }

        private void rbUkryj_Checked(object sender, RoutedEventArgs e)
        {
            rectangle1.Visibility = Visibility.Hidden;
        }

        private void rbPokaz_Checked(object sender, RoutedEventArgs e)
        {
            rectangle1.Visibility = Visibility.Visible;
        }
    }
}
