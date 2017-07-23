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

namespace roz2zad5
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

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnYes_MouseEnter(object sender, MouseEventArgs e)
        {
            if(btnYes.Margin.Left == 160)
            {
                Thickness margin = btnYes.Margin;
                margin.Left = 245;
                btnYes.Margin = margin;
                margin = btnNo.Margin;
                margin.Left = 160;
                btnNo.Margin = margin;
            }
            else
            {
                Thickness margin = btnYes.Margin;
                margin.Left = 160;
                btnYes.Margin = margin;
                margin = btnNo.Margin;
                margin.Left = 245;
                btnNo.Margin = margin;
            }
        }
    }
}
