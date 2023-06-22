using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EP1_JuanP_Cabezas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            String usuario = "estudiante2023";
            String contraseña = "uisrael2023";
            if (txtUsuario.Text == usuario && txtContraseña.Text == contraseña)
            {
                Navigation.PushAsync(new registro(usuario));
            }
            else
            {
                DisplayAlert("Error", "usuario/contaseña incorrectos", "cerrar");
            }

        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {
            txtUsuario.Text = String.Empty;
            txtContraseña.Text = String.Empty;
        }
    }
}