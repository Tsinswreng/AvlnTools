using Avalonia;
using Avalonia.Styling;

namespace Tsinswreng.AvlnTools.Tools;

public static class ExtnStyle{
	public static Style Set(
		this Style z, AvaloniaProperty property, object? value
	){
		z.Setters.Add(new Setter(property, value));

		return z;
	}
}
