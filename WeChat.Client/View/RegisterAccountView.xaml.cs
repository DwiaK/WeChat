using WeChat.Client.ViewModel;

namespace WeChat.Client.View;

public partial class RegisterAccountView : ContentPage
{
	public RegisterAccountView(RegisterAccountViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}