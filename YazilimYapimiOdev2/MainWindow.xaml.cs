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
using YazilimYapimiOdev2.classlar;
using YazilimYapimiOdev2.userControl;

namespace YazilimYapimiOdev2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rdBtn5x5_Click(object sender, RoutedEventArgs e)
        {
            ucCagir.ucEkle(OyunAlani,new uc5x5());
        }

        private void rdBtn6x6_Click(object sender, RoutedEventArgs e)
        {
            ucCagir.ucEkle(OyunAlani, new uc6x6());
        }

        private void rdBtn7x7_Click(object sender, RoutedEventArgs e)
        {
            ucCagir.ucEkle(OyunAlani, new uc7x7());
        }

        private void rdBtn8x8_Click(object sender, RoutedEventArgs e)
        {
            ucCagir.ucEkle(OyunAlani, new uc8x8());
        }

        private void rdBtn9x9_Click(object sender, RoutedEventArgs e)
        {
            ucCagir.ucEkle(OyunAlani, new uc9x9());
        }
    }
}
