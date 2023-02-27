using WeChat.Client.DataContext;

namespace WeChat.Client.Model
{
    class ContactModel
    {
        public string username { get; set; }
        public List<string> messages { get; set; }

        public List<ContactModel> GetContact()
        {
            IContactDataContext contact = new ContactDataContext();
            return contact.GetContacts();
        }
    }
}
