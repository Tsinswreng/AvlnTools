using Avalonia.Controls;

namespace Tsinswreng.AvlnTools.Navigation;
public  partial interface IViewNavi{
	//public ContentControl? Current{get;}
	public bool Back();
	public void GoTo(Control view);
}
