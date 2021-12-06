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

namespace Projekt_PalDavid
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

        private void hozzaadas_Click(object sender, RoutedEventArgs e)
        {
            if(feladatNeve.Text != "") 
            {
                feladatok.Items.Add(feladatNeve.Text);
                feladatNeve.Clear();
            }
                
        }

        private void athelyezes_Click(object sender, RoutedEventArgs e)
        {
            toroltek.Items.Add(feladatok.SelectedItem);
            feladatok.Items.Remove(feladatok.SelectedItem);
            
        }

        private void torles_Click(object sender, RoutedEventArgs e)
        {
            toroltek.Items.Remove(toroltek.SelectedItem);
        }

        private void visszaalitas_Click(object sender, RoutedEventArgs e)
        {
            feladatok.Items.Add(toroltek.SelectedItem);
            toroltek.Items.Remove(toroltek.SelectedItem);
        }
    }
}
