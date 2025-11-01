namespace Tsinswreng.AvlnTools.Navigation;
using Avalonia.Controls;

public partial interface IViewNavi{
	//public ContentControl? Current{get;}
	public bool Back();
	public void GoTo(Control view);
}
