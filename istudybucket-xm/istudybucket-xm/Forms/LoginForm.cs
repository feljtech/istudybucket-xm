using System;

namespace istudybucket_xm
{
    class LoginForm
    {
        public string Username { get; set; }
        public string Password { get; set; }
        
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