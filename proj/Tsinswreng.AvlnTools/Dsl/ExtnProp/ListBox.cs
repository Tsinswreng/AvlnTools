
namespace Tsinswreng.AvlnTools.Dsl.PropExtn;

using System.Collections;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using C = Avalonia.Controls.ListBox;


public static partial class ExtnProp{
	extension(C z){
		public DirectProperty<SelectingItemsControl, object?> PropSelectedItem=>C.SelectedItemProperty;
	}
}
