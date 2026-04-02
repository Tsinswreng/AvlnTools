
namespace Tsinswreng.AvlnTools.Dsl.PropExtn;
using Avalonia;
using Avalonia.Controls;
using C = Avalonia.Layout.Layoutable;


public static partial class ExtnProp{
	extension(C z){
		public StyledProperty<f64> PropWidth=>C.WidthProperty;
		public StyledProperty<f64> PropHeight=>C.HeightProperty;
		public StyledProperty<f64> PropMinWidth=>C.MinWidthProperty;
		public StyledProperty<f64> PropMinHeight=>C.MinHeightProperty;
		public StyledProperty<Thickness> PropMargin=>C.MarginProperty;
		
	}
}
