using System;
using System.Collections;
using System.Collections.Generic;
using Avalonia.Controls;
using Tsinswreng.CsTools;

namespace Tsinswreng.AvlnTools.Dsl;

public  partial class DslFactory{
	public static Button _Button(){return new Button();}
	public static Border _Border(){return new Border();}
	public static ScrollViewer _ScrollViewer(){return new ScrollViewer();}
	public static GridSplitter _GridSplitter(){return new GridSplitter();}
	public static TabControl _TabControl(){return new TabControl();}
	public static TabItem _TabItem(){return new TabItem();}
	public static TextBox _TextBox(){return new TextBox();}
	public static ItemsControl _ItemsControl(){return new ItemsControl();}
	public static TextBlock _TextBlock(){return new TextBlock();}
	public static StackPanel _StackPanel(){return new StackPanel();}

	public static SelectableTextBlock _SelectableTextBlock(){return new SelectableTextBlock();}


	public static RowDef RowDef(double value, GridUnitType type){
		return new RowDef(value, type);
	}
	public static ColDef ColDef(double value, GridUnitType type){
		return new ColDef(value, type);
	}

	public static IList<T> Repeat<T>(T Value, u64 Count){
		return ExtnIList.Repeat(Value, Count);
	}
	public static IList<T> Repeat<T>(
		Func<T> ValueMkr
		,u64 Count
	){
		return ExtnIList.Repeat(ValueMkr, Count);
	}
}
