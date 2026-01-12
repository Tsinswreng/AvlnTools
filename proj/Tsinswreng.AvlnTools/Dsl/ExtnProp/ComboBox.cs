namespace Tsinswreng.AvlnTools.Dsl.PropExtn;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using C = Avalonia.Controls.ComboBox;


public static partial class ExtnProp{
	extension(C z){
		public DirectProperty<SelectingItemsControl, int> PropSelectedIndex=>C.SelectedIndexProperty;
	}
}
