using Horoscope.ViewModels;
using Microsoft.UI.Xaml.Controls;
using Windows.Globalization;

namespace Horoscope.Views;
public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel { get; set; }
    public MainPage()
    {
        InitializeComponent();

        ViewModel = new MainViewModel();

        ApplicationLanguages.PrimaryLanguageOverride = "es";

        App.WindowEx.ExtendsContentIntoTitleBar = true;
        App.WindowEx.SetTitleBar(AppTitlteBar);

    }
}
