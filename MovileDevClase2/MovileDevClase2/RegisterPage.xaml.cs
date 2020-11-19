using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovileDevClase2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private void ButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmailLabel.Text) || string.IsNullOrEmpty(NameLabel.Text) || string.IsNullOrEmpty(PasswordLabel.Text) || string.IsNullOrEmpty(PasswordConfirmLabel.Text))
            {
                DisplayAlert("Error", "Debe llenar todos los campos", "ok");
                EmailLabel.Text = null;
                NameLabel.Text = null;
                PasswordLabel.Text = null;
                PasswordConfirmLabel.Text = null;
            }
            else if (PasswordLabel.Text != PasswordConfirmLabel.Text)
            {
                DisplayAlert("Error", "Las contraseñas no coinciden", "ok");
                EmailLabel.Text = null;
                NameLabel.Text = null;
                PasswordLabel.Text = null;
                PasswordConfirmLabel.Text = null;
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}