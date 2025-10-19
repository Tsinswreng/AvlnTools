
namespace Tsinswreng.AvlnTools.Dsl.PropExtn;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using C = Avalonia.Controls.ContentControl;


public static partial class ExtnProp{
	public static StyledProperty<obj?> PropContent_(
		this C z
	){
		return C.ContentProperty;
	}
}
