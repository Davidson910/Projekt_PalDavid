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
        List<CheckBox> feladatokElemei = new List<CheckBox>();
        List<CheckBox> toroltekElemei = new List<CheckBox>();

        public MainWindow()
        {
            InitializeComponent();
            feladatok.ItemsSource = feladatokElemei;
            toroltek.ItemsSource = toroltekElemei;
        }

        private void hozzaadas_Click(object sender, RoutedEventArgs e)
        {
            if(feladatNeve.Text != "")
            {
                CheckBox feladat = new CheckBox();
                feladat.IsChecked = false;
                feladat.Content = feladatNeve.Text;
                feladatokElemei.Add(feladat);
                feladatNeve.Clear();
                feladatok.Items.Refresh();
                feladat.Checked += new RoutedEventHandler(pipa);
                feladat.Unchecked += new RoutedEventHandler(pipa);
            }
                
        }

        private void pipa(object sender, RoutedEventArgs e)
        {
            CheckBox feladat = (CheckBox)sender;
            if (feladat.IsChecked == true)
            {
                feladat.Foreground = Brushes.Gray;
                feladat.FontStyle = FontStyles.Italic;
            }
            else
            {
                feladat.Foreground = Brushes.Black;
                feladat.FontStyle = FontStyles.Normal;
            }

        }

        private void athelyezes_Click(object sender, RoutedEventArgs e)
        {
            CheckBox feladat = (CheckBox)feladatok.SelectedItem;
            toroltekElemei.Add(feladat);
            feladatokElemei.Remove(feladat);
            feladatNeve.Clear();
            feladatok.Items.Refresh();
            toroltek.Items.Refresh();
            
        }

        private void torles_Click(object sender, RoutedEventArgs e)
        {
            CheckBox feladat = (CheckBox)toroltek.SelectedItem;
            toroltekElemei.Remove(feladat);
            toroltek.Items.Refresh();
        }

        private void visszaalitas_Click(object sender, RoutedEventArgs e)
        {
            CheckBox feladat = (CheckBox)toroltek.SelectedItem;
            feladatokElemei.Add(feladat);
            toroltekElemei.Remove(feladat);
            feladatok.Items.Refresh();
            toroltek.Items.Refresh();
        }

        private void feladatok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CheckBox feladat = (CheckBox)feladatok.SelectedItem;
            if(feladat != null)
            feladatNeve.Text = (string)feladat.Content;
        }

        private void modositas_Click(object sender, RoutedEventArgs e)
        {
            CheckBox feladat = (CheckBox)feladatok.SelectedItem;
            feladat.Content = feladatNeve.Text;
        }
    }
}
