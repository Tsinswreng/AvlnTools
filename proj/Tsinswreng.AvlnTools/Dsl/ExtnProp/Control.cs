
namespace Tsinswreng.AvlnTools.Dsl.PropExtn;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using C = Avalonia.Controls.Control;


public static partial class ExtnProp{
	extension(C z){
		public StyledProperty<obj?> PropDataContext=>C.DataContextProperty;
	}
	public static StyledProperty<obj?> PropDataContext_(
		this C z
	){
		return C.DataContextProperty;
	}
}
