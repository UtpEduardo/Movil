using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Producto1.Models;

namespace Producto1
{
    public partial class MainPage : ContentPage
    {
        Ecuacion forGeneral = new Ecuacion();
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            forGeneral.a = double.Parse(VdA.Text);
            forGeneral.b = double.Parse(VdB.Text);
            forGeneral.c = double.Parse(VdC.Text);

            VX1.Text = "x1: " + forGeneral.SEcuacioX1();
            VX2.Text = "x2: " + forGeneral.SEcuacioX2();
        }

        private void sliderG_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void stepperG_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
    }
}
