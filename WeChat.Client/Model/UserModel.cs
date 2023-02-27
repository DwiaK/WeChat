using WeChat.Client.DataContext;

namespace WeChat.Client.Model
{
    class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<UserModel> GetUser()
        {
            IUserDataContext user = new UserDataContext();
            return user.GetUsers();
        }
    }
}
