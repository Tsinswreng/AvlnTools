
namespace Tsinswreng.AvlnTools.Dsl.PropExtn;
using Avalonia;
using Avalonia.Controls;
using C = Avalonia.Controls.TextBlock;


public static partial class ExtnProp{
	public static StyledProperty<str?> PropText_(
		this C z
	){
		return C.TextProperty;
	}

	public static StyledProperty<f64> PropFontSize_(
		this C z
	){
		return C.FontSizeProperty;
	}
}
