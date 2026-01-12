namespace Tsinswreng.AvlnTools.Tools;
using Avalonia.Controls;

public static class ExtnAutoGrid {
	extension(AutoGrid z){
		public ColumnDefinitions ColDefs{
			get{
				return z.Grid.ColumnDefinitions;
			}
		}
		public RowDefinitions RowDefs{
			get{
				return z.Grid.RowDefinitions;
			}
		}
	}
}
