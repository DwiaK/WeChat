using WeChat.Client.Model;

namespace WeChat.Client.DataContext
{
    interface IUserDataContext
    {
        List<UserModel> GetUsers();
    }
}
