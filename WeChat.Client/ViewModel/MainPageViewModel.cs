namespace WeChat.Client.ViewModel
{
    public partial class MainPageViewModel : BaseViewModel
    {
        // Comando tela de login
        [RelayCommand]
        async Task GoToLoginPage()
        {
            // Pode passar parâmetros
            //Shell.Current.GoToAsync($"{nameof(LoginAccountView)}?");
            await Shell.Current.GoToAsync($"{nameof(LoginAccountView)}");
        }
    }
}
