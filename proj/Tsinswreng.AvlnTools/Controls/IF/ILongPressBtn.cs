using System;

namespace Tsinswreng.AvlnTools.Controls.IF;

public interface ILongPressBtn{
	public event EventHandler? OnLongPressed;
	public i64 LongPressDurationMs{get;set;}
}
