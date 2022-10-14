using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using Producto1.ViewModels;
using Producto1.Models;


namespace Producto1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaNombre : ContentPage
    {
        ManejoDatosViewModels consultaN;
        ObservableCollection<Medicamentos> medicamento;
        public ConsultaNombre()
        {
            InitializeComponent();
            consultaN = new ManejoDatosViewModels();
            medicamento = new ObservableCollection<Medicamentos>();
        }

        private void Visualizar_Clicked(object sender, EventArgs e)
        {
            string Nom;

            Nom = cadenacaducidad.Text;
            medicamento = consultaN.ConsultaNom(Nom);

            if (medicamento.Count != 0)
            {
                imagen.Source = medicamento[0].Imagen;
                nombre.Text = "Nombre: " + medicamento[0].Nombre;
                precio.Text = "$ " + Convert.ToString(medicamento[0].Precio);
                presentacion.Text = medicamento[0].Presentacion;
            }
            else DisplayAlert("Alerta", "No hay Resulado de la Busqueda", "ok");

        }
    }
}