using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Client.Model;

namespace WeChat.Client.DataContext
{
    interface IContactDataContext
    {
        List<ContactModel> GetContacts();
    }
}
