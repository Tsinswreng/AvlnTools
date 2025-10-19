
namespace Tsinswreng.AvlnTools.Dsl.PropExtn;

using System.Collections;
using Avalonia;
using Avalonia.Controls;
using C = Avalonia.Controls.ItemsControl;


public static partial class ExtnProp{
	public static StyledProperty<IEnumerable?> PropItemsSource_(
		this C z
	){
		return C.ItemsSourceProperty;
	}
}
