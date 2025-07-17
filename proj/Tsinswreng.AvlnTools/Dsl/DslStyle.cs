
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Styling;
using Tsinswreng.AvlnTools.Tools;

namespace Tsinswreng.AvlnTools.Dsl;

public static class DslStyle{

	public static Style MkStyForAnyControl(){
		var Ans = new Style(x=>
			x.Is<Control>()
		);
		return Ans;
	}

	public static Style GridShowLines(
		this Style z
	){
		z.Set(
			Grid.ShowGridLinesProperty
			,true
		);
		return z;
	}

	public static Style GridShowLines(
		//this Avalonia.StyledElement.Styles z
	){
		var Ans = new Style(x=>
			x.Is<Grid>()
		);
		Ans.GridShowLines();
		return Ans;
	}



	public static Style NoCornerRadius(
		this Style z
	){
		z.Set(
			TemplatedControl.CornerRadiusProperty
			, new CornerRadius(0)
		);
		return z;
	}

	public static Style NoPadding(
		this Style z
	){
		z.Set(
			TemplatedControl.PaddingProperty
			,new Thickness(0)
		);
		return z;
	}

	public static Style NoMargin(
		this Style z
	){
		z.Set(
			global::Avalonia.Layout.Layoutable.MarginProperty
			, new Thickness(0)
		);
		return z;
	}




}
