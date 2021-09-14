using System;

namespace istudybucket.Forms
{
    class LoginForm
    {
        private string Username { get; set; }
        private string Password { get; set; }
        
        public LoginForm() {}

        public LoginForm(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public Boolean IsValid()
        {
            return !Username.Equals("") && !Password.Equals("");
        }
    }
}