using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace roz6
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private MainWindow mainWindow = null;
        private bool czyNowyProdukt;
        private Produkt nowyProdukt = null;
        public Window1()
        {
            InitializeComponent();
        }

        public Window1(MainWindow mainWin, bool czyNowy = false)
        {
            InitializeComponent();
            mainWindow = mainWin;
            czyNowyProdukt = czyNowy;
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            Produkt produktyZListy = mainWindow.lstProdukty.SelectedItem as Produkt;
            if(produktyZListy != null && !czyNowyProdukt)
            {
                gridProdukt.DataContext = produktyZListy;
            }
            else if(czyNowyProdukt)
            {
                nowyProdukt = new Produkt("AA-00", "", 0, "");
                gridProdukt.DataContext = nowyProdukt;
            }
        }

        private void btnPotwierdz_Click(object sender, RoutedEventArgs e)
        {
            if (czyNowyProdukt)
                mainWindow.ListaProduktow.Add(nowyProdukt);
            this.DialogResult = true;
        }
    }
}
