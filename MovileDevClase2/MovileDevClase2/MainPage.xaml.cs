using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MovileDevClase2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void ButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmailLabel.Text) || string.IsNullOrEmpty(PasswordLabel.Text))
            {
                DisplayAlert("Error", "Email y/o contraseña no pueden estar vacios", "ok");
                EmailLabel.Text = null;
                PasswordLabel.Text = null;
            }
            else 
            {
                DisplayAlert("Bienvenido", "Bienvenido, " + EmailLabel.Text, "ok");
                EmailLabel.Text = null;
                PasswordLabel.Text = null;
            }
        }

        private void LabelTapped(object sender, EventArgs e)
        {
           Navigation.PushAsync(new RegisterPage());
        }
    }
}
