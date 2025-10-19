
namespace Tsinswreng.AvlnTools.Dsl.PropExtn;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using C = Avalonia.Controls.Primitives.TemplatedControl;


public static partial class ExtnProp{
	public static StyledProperty<IBrush?> PropBackground_(
		this C z
	){
		return C.BackgroundProperty;
	}
	public static StyledProperty<IBrush?> PropForeground_(
		this C z
	){
		return C.ForegroundProperty;
	}

	public static StyledProperty<f64> PropWidth_(
		this C z
	){
		return C.WidthProperty;
	}

	public static StyledProperty<f64> PropMinWidth_(
		this C z
	){
		return C.MinWidthProperty;
	}

	public static StyledProperty<f64> PropMaxWidth_(
		this C z
	){
		return C.MaxWidthProperty;
	}


	public static StyledProperty<f64> PropHeight_(
		this C z
	){
		return C.HeightProperty;
	}

	public static StyledProperty<f64> PropMinHeight_(
		this C z
	){
		return C.MinHeightProperty;
	}

	public static StyledProperty<f64> PropMaxHeight_(
		this C z
	){
		return C.MaxHeightProperty;
	}
}
