using Android.App;
using Android.Content.PM;
using Avalonia;
using Avalonia.Android;

namespace Tsinswreng.AvlnTools.Example.Android;

[Activity(
    Label = "Tsinswreng.AvlnTools.Example.Android",
    Theme = "@style/MyTheme.NoActionBar",
    Icon = "@drawable/icon",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity<App>
{
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .WithInterFont();
    }
}
