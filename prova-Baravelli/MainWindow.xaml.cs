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

namespace prova_Baravelli
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

        private void aggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            
            
            
            Libro libro = new Libro(autore.Text,editore.Text,anno_.Text,titolo.Text,npagine.Text);
            elencoLibriBiblio.Add(libro);
            elencoLibri.Items.Clear();

            elencoLibri.Items.Add(libro);


        }

        private void tempolettura_Click(object sender, RoutedEventArgs e)
        {

            int tempoLettura = tempoLettura.toString();
// questo è il commento


        }
    }
}
