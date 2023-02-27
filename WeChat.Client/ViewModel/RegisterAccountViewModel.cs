namespace WeChat.Client.ViewModel
{
    public partial class RegisterAccountViewModel : BaseViewModel
    {
        [ObservableProperty]
        string email;

        [ObservableProperty]
        string password;

        [ObservableProperty]
        string username;

        RegisterAccountService registerAccountService = new RegisterAccountService();

        [RelayCommand]
        async Task RegisterAccount()
        {
            try
            {
                // Esperar resposta (método login into account)
                await registerAccountService.RegisterAccount(email, password, username);

                // Mensagem(Alert) de sucesso
                await App.Current.MainPage.DisplayAlert("Success", "Your account has been successfully created.", "OK");
            }
            catch (Exception ex)
            {
                // Erro
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
                throw;
            }
        }

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
