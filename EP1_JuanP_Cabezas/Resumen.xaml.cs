using EP1_JuanP_Cabezas.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Forms.Internals.Profile;

namespace EP1_JuanP_Cabezas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(String dato1, string dato2, string dato3, string dato5, string dato6, string dato7, string dato8)
        {
            InitializeComponent();
            txtnombre.Text = dato1;
            txtApellido.Text = dato2;
            txtEdad.Text = dato3;
            txtPais.Text = dato5;
            txtCiudad.Text = dato6;
            txtMonto.Text = dato7;
            txtPago.Text = dato8;
            

        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {


            Navigation.PushAsync(new Login());
           

        }
    }
}