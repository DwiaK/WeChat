using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Client.Model;

namespace WeChat.Client.DataContext
{
    class ContactDataContext : IContactDataContext
    {
        public List<ContactModel> GetContacts()
        {
            var listContacts = new List<ContactModel>();
            var listMessages = new List<string>();

            // Adicionar mensagens na lista
            listMessages.Add("Mensagem Teste 1");
            listMessages.Add("Mensagem Teste 2");

            // Adicionar uma lista de contatos
            listContacts.Add(new ContactModel()
            {
                username = "Test",
                messages = listMessages
            });

            return listContacts;
        }
    }
}
