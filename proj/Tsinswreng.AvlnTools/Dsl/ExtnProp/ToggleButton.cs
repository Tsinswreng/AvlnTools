
namespace Tsinswreng.AvlnTools.Dsl.PropExtn;
using Avalonia;
using Avalonia.Controls;
using C = Avalonia.Controls.Primitives.ToggleButton;


public static partial class ExtnProp{
	extension(C z){
		public StyledProperty<bool?> PropIsChecked=>C.IsCheckedProperty;
		public StyledProperty<bool> PropIsCancel=>C.IsCancelProperty;
	}
	public static StyledProperty<bool?> PropIsChecked_(
		this C z
	){
		return C.IsCheckedProperty;
	}

	public static StyledProperty<bool> PropIsCancel_(
		this C z
	){
		return C.IsCancelProperty;
	}
}
