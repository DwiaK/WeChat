using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Firebase;

namespace WeChat.Client.Services
{
    public class RegisterAccountService
    {
        private string _email;
        private string _password;
        private string _username;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public async Task RegisterAccount(string email, string password, string username)
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(Settings.webApiKey));
            var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password, username);
            var token = auth.FirebaseToken;
        }
    }
}
