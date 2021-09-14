using System;

namespace istudybucket.Forms
{
    public class RegisterForm
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public RegisterForm(string username, string email, string password)
        {
            Username = username;
            Password = password;
            Email = email;
        }

        public bool IsEmailValid()
        {
            return !Email.Equals("");
        }

        public bool IsUsernameValid()
        {
            return !Username.Equals("");
        }

        public bool IsPasswordValid()
        {
            return !Password.Equals("");
        }
    }
}