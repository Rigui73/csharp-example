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
    /// Lógica de interacción para Resultado.xaml
    /// </summary>
    public partial class Resultado : Page
    {
        public Resultado(Banco LaCaixa)
        {
            InitializeComponent();
            Metodo(LaCaixa);
        }

        public void Metodo (Banco NombreBanco)
        {
            InitializeComponent();

            //Eliminamos el StackPanel del Grid Resultado.
            GridResultado.Children.Remove(Respuesta);

            //Creamos un nuevo StackPanel y le asignamos el nombre del eliminado. (Porqué no deja cambiar codigo al estar ejecutado y no lo podríamos insertar).
            StackPanel Resultado2 = new StackPanel();
            Resultado2.Name = "Respuesta";
            //Añadimos los valores de Resultado2
            GridResultado.Children.Add(Resultado2);

            foreach (var cli in NombreBanco.ListaClientes)
            {
                TextBlock bloque = new TextBlock();

                //Mostramos los datos de la lista en TextBlock.
                bloque.Text = "Tu nombre y apellido son: " + cli.Nombre + " " + cli.Apellido;
                Resultado2.Children.Add(bloque);
            }
        }
    }
}
