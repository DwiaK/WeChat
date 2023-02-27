using WeChat.Client.View;

namespace WeChat.Client;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registrar Rota
        Routing.RegisterRoute(nameof(LoginAccountView), typeof(LoginAccountView));
        Routing.RegisterRoute(nameof(RegisterAccountView), typeof(RegisterAccountView));
        Routing.RegisterRoute(nameof(WeChatView), typeof(WeChatView));
    }
}