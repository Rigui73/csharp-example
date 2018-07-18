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
    /// Lógica de interacción para Formulario.xaml
    /// </summary>
    public partial class Formulario : Page
    {
        Banco LaCaixa;

        public Formulario(Banco LaCaixa)
        {
            InitializeComponent();

            //Iniciem la página amb un Banco que és obligatori.
            this.LaCaixa = LaCaixa;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Añadimos las variables como nuevo cliente a la ListaClientes 
            Cliente NuevoCliente = new Cliente(Nombre.Text, Apellido.Text);
            LaCaixa.ListaClientes.Add(NuevoCliente);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Cambiamos de Frame declarando el constructor de Resultado().
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Resultado(LaCaixa));
        }
    }
}
