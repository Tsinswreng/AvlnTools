
namespace Tsinswreng.AvlnTools.Dsl.PropExtn;

using System.Collections;
using Avalonia;
using Avalonia.Controls;
using C = Avalonia.Controls.ItemsControl;


public static partial class ExtnProp{
	extension(C z){
		public StyledProperty<IEnumerable?> PropItemsSource=>C.ItemsSourceProperty;
	}
}
