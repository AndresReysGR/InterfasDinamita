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

namespace InterfasDinamita
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            gridInformacion.Children.Clear();
            switch(cbUsuario.SelectedIndex)
            {
                case 0: gridInformacion.Children.Add(new Alumno());
                    break;

                case 1:
                    gridInformacion.Children.Add(new Docente());
                    break;


            }

            switch(cbUsuario.SelectedIndex)
            {
                case 0:
                      ((Alumno)(gridInformacion.Children[0])).txbNombreA.Text="";
                      ((Alumno)(gridInformacion.Children[0])).txbMatriculaA.Text = "";
                      ((Alumno)(gridInformacion.Children[0])).txbPreparatoriaA.Text = "";
                    break;

                case 1:
                    ((Docente)(gridInformacion.Children[0])).txbNombreD.Text = "";
                    ((Docente)(gridInformacion.Children[0])).txbCodigoD.Text = "";
                    ((Docente)(gridInformacion.Children[0])).txbTituloD.Text = "";
                    ((Docente)(gridInformacion.Children[0])).txbMateriaD.Text = "";
                    break;

                default:
                    break;
            }
            btnGuardar.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;

        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            gridInformacion.Children.Clear();
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            gridInformacion.Children.Clear();
            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
        }



    }
}
