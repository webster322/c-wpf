using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace roz7._7
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string plik1 = @"..\..\dane\Produkty.xml";
        private string plik2 = @"..\..\dane\Produkty2.xml";
        private XElement wykazProduktow;
        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            if (File.Exists(plik1))
            {
                wykazProduktow = XElement.Load(plik1);
            }
            gridProdukty.DataContext = wykazProduktow;
            ObservableCollection<string> ListaMagazynow = new ObservableCollection<string>() { "Katowice 1", "Katowice 2", "Gliwice 1" };
            nazwaMagazynu.ItemsSource = ListaMagazynow;
        }

        private void btnZapisz_Click(object sender, RoutedEventArgs e)
        {
            wykazProduktow.Save(plik2);
            MessageBox.Show("Pomyślnie zapisano dane do pliku");
        }
    }
}
