using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace istudybucket_xm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        
        public LoginPage()
        {
            InitializeComponent();
            
        }

        private void OnSignInClicked(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(EntryUsername.Text, EntryPassword.Text);
            if (loginForm.IsValid())
            {
                DisplayAlert("Login", "Login Successful", "Okay");
            }
            else
            {
                DisplayAlert("Login", "Login Unsuccessful", "Try Again");
            }
        }
    }
}