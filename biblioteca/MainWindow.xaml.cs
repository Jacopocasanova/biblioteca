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

namespace biblioteca
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> listaLibri = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_aggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            string libro;
            lst_libri_.Items.Clear();
            libro = txt_nomeLibro.Text;
            listaLibri.Add(libro);

            foreach (string libro1 in listaLibri)
            {
               
                lst_libri_.Items.Add(libro1);

            }
        }
    }
}
