using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
namespace WeChat.Client.ViewModel
{
    public partial class LoginAccountViewModel : BaseViewModel
    {
        [ObservableProperty]
        public string username;

        [ObservableProperty]
        public string password;

        LoginAccountService loginAccountService = new LoginAccountService();

        [RelayCommand]
        async Task LogInAccount()
        {
            try
            {
                // Esperar resposta (método login into account)
                await loginAccountService.LogIntoAccount(username, password);

                // Ir para a rota WeChatView
                await Shell.Current.GoToAsync(nameof(WeChatView));
            }
            catch
            {
                await App.Current.MainPage.DisplayAlert("Error", "Invalid account", "OK");
            }
        }

        [RelayCommand]
        async Task GoToRegisterPage()
        {
            await Shell.Current.GoToAsync(nameof(RegisterAccountView));
        }
    }
}
