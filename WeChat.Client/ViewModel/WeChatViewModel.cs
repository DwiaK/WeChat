using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
namespace WeChat.Client.ViewModel
{
    public partial class WeChatViewModel : BaseViewModel
    {
        [ObservableProperty]
        string indexUser;

        public WeChatViewModel() 
        {
            GetUserData();
            GetUserContacts();
        }

        private void GetUserData()
        {
            var userInfo = JsonConvert.DeserializeObject<FirebaseAuth>(Preferences.Get("FreshFirebaseToken", ""));
            indexUser = userInfo.User.DisplayName;
        }
        private void GetUserContacts()
        {

        }

        [RelayCommand]
        async Task AddNewContact()
        {

        }
    }
}
