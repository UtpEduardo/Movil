using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Producto1.Models;
using Producto1.ViewModels;
using System.Collections.ObjectModel;

namespace Producto1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListarM : ContentPage
    {
        ManejoDatosViewModels medicina;
        public ListarM()
        {
            InitializeComponent();
            medicina = new ManejoDatosViewModels();
            ObservableCollection<Medicamentos> datos;
            datos = medicina.ObtenerMedicinas();
            collectionview.ItemsSource=datos;
        }
    }
}