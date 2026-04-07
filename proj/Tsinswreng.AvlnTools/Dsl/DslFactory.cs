namespace Tsinswreng.AvlnTools.Dsl;

using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Tsinswreng.CsTools;

public  partial class DslFactory{
	public static RowDef RowDef(double value, GridUnitType type){
		return new RowDef(value, type);
	}
	public static ColDef ColDef(double value, GridUnitType type){
		return new ColDef(value, type);
	}
}
