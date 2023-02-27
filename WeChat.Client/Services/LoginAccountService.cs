using Firebase.Auth;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Firebase;

namespace WeChat.Client.Services
{
    public class LoginAccountService
    {
        private string _email;
        private string _password;

        FirebaseAuthProvider authProvider = new FirebaseAuthProvider(new FirebaseConfig(Settings.webApiKey));

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

        public async Task LogIntoAccount(string email, string password)
        {
            var auth = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
            var content = await auth.GetFreshAuthAsync();
            var serializedContent = JsonConvert.SerializeObject(content);

            Preferences.Set("FreshFirebaseToken", serializedContent);
        }
    }
}
