using Avalonia.Controls;
using Control = Avalonia.Controls.ContentControl;
namespace Tsinswreng.AvlnTools.Navigation;


public interface IViewNavigator{

	public bool Back();

	public void GoTo(Control view);
}
