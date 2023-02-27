using WeChat.Client.ViewModel;

namespace WeChat.Client.View;

public partial class WeChatView : ContentPage
{
	public WeChatView(WeChatViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}