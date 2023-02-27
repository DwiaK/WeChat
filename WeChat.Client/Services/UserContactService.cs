using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Client.Model;
using WeChat.Firebase;

namespace WeChat.Client.Services
{
    public class UserContactService
    {
        public List<string> userContacts = new List<string>();

        //public List<string> GetUserContacts()
        //{
        //    Settings.fbClient.Child();
        //}

        public void AddNewContact(string username)
        {
            //Settings.fbClient.Child("Contacts").PostAsync(new ContactModel({
                
            //}));
        }
    }
}
