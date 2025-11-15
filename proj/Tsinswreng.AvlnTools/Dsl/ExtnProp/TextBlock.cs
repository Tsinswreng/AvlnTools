
namespace Tsinswreng.AvlnTools.Dsl.PropExtn;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using C = Avalonia.Controls.TextBlock;


public static partial class ExtnProp{
	extension(C z){
		public StyledProperty<str?> PropText=>C.TextProperty;
		public StyledProperty<f64> PropFontSize=>C.FontSizeProperty;
		public StyledProperty<TextDecorationCollection?> PropTextDecorations=>C.TextDecorationsProperty;
	}

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
