using Horoscope.Views;
using Microsoft.UI.Xaml;

namespace Horoscope;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
    {
        var mainPage = new MainPage();
        WindowEx.Content = mainPage;
        WindowEx.Activate();
    }

    public static WindowEx WindowEx { get; } = new MainWindow();
}
