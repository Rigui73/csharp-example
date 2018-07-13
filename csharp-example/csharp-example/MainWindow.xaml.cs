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
            // Inicia la aplicación
            InitializeComponent();

            Administrador Jefe = new Administrador("Linus", "Trovalds");
            LaCaixa = new Banco(Jefe, "LaCaixa");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Declaramos un TextBlock y las variables que utilizaremos
            TextBlock bloque = new TextBlock();

            //Declaramos las variables añadiendo el valor del label en XAML 
            var nombre = Nombre.Text;
            var apellido = Apellido.Text;

            bloque.Text = nombre + apellido;
            Respuesta.Children.Add(bloque);

            //Añadimos el nuevo cliente a la ListaClientes 
            Cliente NuevoCliente = new Cliente(Nombre.Text, Apellido.Text);
            LaCaixa.ListaClientes.Add(NuevoCliente);
        }
    }
}
