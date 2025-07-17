using Avalonia.Controls;

namespace Tsinswreng.Avalonia.Dsl;

public class AvlnDslFactory{
	public static Button Button(){return new Button();}
	public static Border Border(){return new Border();}
	public static ScrollViewer ScrollViewer(){return new ScrollViewer();}
	public static GridSplitter GridSplitter(){return new GridSplitter();}
	public static RowDef RowDef(double value, GridUnitType type){
		return new RowDef(value, type);
	}
	public static ColDef ColDef(double value, GridUnitType type){
		return new ColDef(value, type);
	}
}
