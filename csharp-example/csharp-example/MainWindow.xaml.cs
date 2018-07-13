using csharp_example.Models;
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

namespace csharp_example
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Banco LaCaixa;

        public MainWindow()
        {
            InitializeComponent();

            Administrador Jefe = new Administrador("Linus", "Trovalds");
            LaCaixa = new Banco(Jefe, "LaCaixa");
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Declaramos las variables añadiendo el valor del label en XAML 
            var nombre = Nombre.Text;
            var apellido = Apellido.Text;

            //Añadimos las variables como nuevo cliente a la ListaClientes 
            Cliente NuevoCliente = new Cliente(Nombre.Text, Apellido.Text);
            LaCaixa.ListaClientes.Add(NuevoCliente);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            foreach (var cli in LaCaixa.ListaClientes)
            {
                //Declaramos un TextBlock
                TextBlock bloque = new TextBlock();

                //Mostramos los datos de la lista en textblock
                bloque.Text = cli.Nombre + " / " + cli.Apellido;
                Respuesta.Children.Add(bloque);
            }
        }
    }
}