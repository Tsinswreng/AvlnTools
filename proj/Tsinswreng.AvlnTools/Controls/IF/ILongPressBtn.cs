using System;

namespace Tsinswreng.AvlnTools.Controls.IF;

public  partial interface ILongPressBtn{
	public event EventHandler? OnLongPressed;
	public i64 LongPressDurationMs{get;set;}
}
