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
        List<int> listaPagine = new List<int>();
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

        private void btn_aggiungiPagine_Click(object sender, RoutedEventArgs e)
        {
            string pagine1;
            lst_pagine.Items.Clear();
            pagine1 = txt_numeroPagine.Text;
            int pagina = Convert.ToInt32(pagine1);
            listaPagine.Add(pagina);

            foreach (int pagine2 in listaPagine)
            {

                lst_pagine.Items.Add(pagine2);

            }
        }
    }
}
