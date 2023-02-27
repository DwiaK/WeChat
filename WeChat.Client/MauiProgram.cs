using WeChat.Client.View;
using WeChat.Client.ViewModel;

namespace WeChat.Client
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // goto nameof(MainPage)

            // MainPage
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();

            // LoginPage
            builder.Services.AddSingleton<LoginAccountView>();
            builder.Services.AddSingleton<LoginAccountViewModel>();

            // RegisterPage
            builder.Services.AddSingleton<RegisterAccountView>();
            builder.Services.AddSingleton<RegisterAccountViewModel>();

            // WeChatPage
            builder.Services.AddSingleton<WeChatView>();
            builder.Services.AddSingleton<WeChatViewModel>();

            // Note: Transient mode
            //builder.Services.AddTransient<MainPage>();
            //builder.Services.AddTransient<MainPageViewModel>();

            return builder.Build();
        }
    }
}