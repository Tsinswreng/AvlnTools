namespace Tsinswreng.AvlnTools.Tools;
using Avalonia.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using Tsinswreng.CsCore;


public partial class AutoGrid
	:ICollection<Control>
{

	public Grid Grid = new Grid();
	public i32 Index = 0;
	public bool IsRow = true;

	public AutoGrid(bool IsRow = true){
		this.IsRow = IsRow;
	}

	public int Count => throw new NotImplementedException();

	public bool IsReadOnly => throw new NotImplementedException();

	protected ICollection<Control> Inner{get{
		return Grid.Children;
	}}

	[Impl]
	public void Add(Control control= default!){
		if(control == null){
			Index++;
			//return NIL;
			return;
		}
		Grid.Children.Add(control);
		if(IsRow){
			Grid.SetRow(control, Index++);
		}else{
			Grid.SetColumn(control, Index++);
		}
		//return NIL;
		return;
	}

	[Impl]
	public void Clear() {
		Inner.Clear();
	}

	[Impl]
	public bool Contains(Control item) {
		return Inner.Contains(item);
	}

	[Impl]
	public void CopyTo(Control[] array, int arrayIndex) {
		Inner.CopyTo(array, arrayIndex);
	}

	[Impl]
	public IEnumerator<Control> GetEnumerator() {
		return Inner.GetEnumerator();
	}

	[Impl]
	public bool Remove(Control item) {
		return Inner.Remove(item);
	}

	[Impl]
	IEnumerator IEnumerable.GetEnumerator() {
		return GetEnumerator();
	}
}
