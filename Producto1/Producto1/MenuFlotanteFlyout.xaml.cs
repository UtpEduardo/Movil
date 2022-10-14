using Producto1.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Producto1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuFlotanteFlyout : ContentPage
    {
        public ListView ListView;

        public MenuFlotanteFlyout()
        {
            InitializeComponent();

            BindingContext = new MenuFlotanteFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class MenuFlotanteFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MenuFlotanteFlyoutMenuItem> MenuItems { get; set; }

            public MenuFlotanteFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MenuFlotanteFlyoutMenuItem>(new[]
                {
                    new MenuFlotanteFlyoutMenuItem { Id = 0, Title = "Ec.Cuadrática",TargetType=typeof(MainPage),IconSource="grafica.png" },
                    new MenuFlotanteFlyoutMenuItem { Id = 1, Title = "Listar Medicamentos",TargetType=typeof(ListarM),IconSource="lista.png" },
                    new MenuFlotanteFlyoutMenuItem { Id = 2, Title = "Consulta Por Nombre",TargetType=typeof(ConsultaNombre),IconSource="Nconsulta.ico" },
                    new MenuFlotanteFlyoutMenuItem { Id = 3, Title = "Consulta Por Presentacion",TargetType=typeof(ConsultaPresentacion),IconSource="Pconsulta.ico" },
                    new MenuFlotanteFlyoutMenuItem { Id = 4, Title = "Consulta Por Caducidad",TargetType=typeof(ConsultaCaducidad),IconSource="Fconsulta.ico"},
                    new MenuFlotanteFlyoutMenuItem { Id = 5, Title = "Venta de Medicamento", TargetType=typeof(Venta),IconSource="tienda.png"},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}