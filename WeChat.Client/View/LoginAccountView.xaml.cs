using WeChat.Client.ViewModel;

namespace WeChat.Client.View;

public partial class LoginAccountView : ContentPage
{
	public LoginAccountView(LoginAccountViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}