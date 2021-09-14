using System;
using istudybucket.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace istudybucket.Pages.Auth
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterButton_OnClicked(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(UsernameEntry.Text, EmailEntry.Text, PasswordEntry.Text);
            DisplayAlert("Reg info", registerForm.Email + registerForm.Password + registerForm.Username, "Ok");
            // throw new NotImplementedException();
        }
    }
}