using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EP1_JuanP_Cabezas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        string usuario;
        public registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "usuario conectado" + " " + "Es" + " " + usuario;
            this.usuario = usuario;
        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            string dato1 = txtNombre.Text;
            string dato2 = txtApellido.Text;
            string dato3 = txtEdad.Text;
            string dato5 = dpPais.SelectedItem.ToString();
            String dato6 = dpCiudad.SelectedItem.ToString();
            string dato7 = txtMonto.Text;
            string dato8 = txtPago.Text;
            
            Navigation.PushAsync(new Resumen(dato1,dato2,dato3,dato5,dato6,dato7,dato8));
        }

        private void btnPago_Clicked(object sender, EventArgs e)
        {

            double Monto = Convert.ToDouble(txtMonto.Text);
            double Pago1 = (1800 *0.05);
            double Pago2 = (Pago1 + Monto);
            double calcularPago = (1800 - Pago2)/3;
            txtPago.Text = calcularPago.ToString();

        }
        private void dpPais_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }


        private void dpCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }