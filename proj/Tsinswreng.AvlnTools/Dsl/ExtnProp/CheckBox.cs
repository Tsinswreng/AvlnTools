
namespace Tsinswreng.AvlnTools.Dsl.PropExtn;
using Avalonia;
using Avalonia.Controls;
using C = Avalonia.Controls.CheckBox;


public static partial class ExtnProp{
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
