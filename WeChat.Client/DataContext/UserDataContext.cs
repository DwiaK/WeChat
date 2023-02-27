using WeChat.Client.Model;

namespace WeChat.Client.DataContext
{
    class UserDataContext : IUserDataContext
    {
        public List<UserModel> GetUsers()
        {
            var listUsers = new List<UserModel>();

            listUsers.Add(new UserModel()
            {
                Id = 1,
                Name = "Exemplo",
                Email = "Exemplo@Exemplo.com",
                Password = "Exemplo"
            });

            return listUsers;
        }
    }
}
