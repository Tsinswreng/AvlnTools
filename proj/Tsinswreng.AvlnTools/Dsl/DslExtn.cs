using System;
using System.Collections.Generic;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Styling;

namespace Tsinswreng.AvlnTools.Dsl;
using Controls = global::Avalonia.Controls.Controls;
using NonGenericList = System.Collections.IList;
public static class DslExtn{

	public static NonGenericList AddInit<TItem>(
		this NonGenericList z
		,TItem Child
		,Action<TItem>? FnInit = null
	){
		z.Add(Child!);
		FnInit?.Invoke(Child);
		return z;
	}

	public static Style Attach(
		this Style z
		,Styles Styles
		,Action<Style>? FnInit = null
	){
		FnInit?.Invoke(z);
		Styles.Add(z);
		return z;
	}

	public static IStyle Attach(
		this IStyle z
		,Styles Styles
		,Action<IStyle>? FnInit = null
	){
		FnInit?.Invoke(z);
		Styles.Add(z);
		return z;
	}


	public static ICollection<IStyle> AddInit<TItem>(
		this ICollection<IStyle> z
		,TItem Child
		,Action<TItem>? FnInit = null
	)where TItem:IStyle{
		z.Add(Child!);
		FnInit?.Invoke(Child);
		return z;
	}

	public static ICollection<TItem> AddInitT<TItem>(
		this ICollection<TItem> z
		,TItem Child
		,Action<TItem>? FnInit = null
	){
		z.Add(Child!);
		FnInit?.Invoke(Child);
		return z;
	}

	public static ICollection<Control> AddInit<TItem>(
		this ICollection<Control> z
		,TItem Child
		,Action<TItem>? FnInit = null
	)where TItem:Control{
		z.Add(Child!);
		FnInit?.Invoke(Child);
		return z;
	}

	public static TControl Attach<TControl>(
		this TControl z
		,ICollection<Control> Controls
		,Action<TControl>? FnInit = null
	)where TControl:Control{
		Controls.AddInit(z,FnInit);
		return z;
	}

	public static TControl Attach<TControl>(
		this TControl z
		,Panel Panel
		,Action<TControl>? FnInit = null
	)where TControl:Control{
		Panel.AddInit(z,FnInit);
		return z;
	}


	public static Controls AddInit<TChild>(
		this Controls z
		,TChild Child
		,Action<TChild>? FnInit = null
	)where TChild: Control{
		z.Add(Child);
		FnInit?.Invoke(Child);
		return z;
	}

	public static Panel AddInit<TChild>(
		this Panel z
		,TChild Child
		,Action<TChild>? FnInit = null
	)where TChild:Control{
		z.Children.AddInit(Child,FnInit);
		return z;
	}

	public static TControl ContentFor<TControl>(
		this TControl z
		,ContentControl ContentControl
		,Action<TControl>? FnInit = null
	){
		ContentControl.Content = z;
		FnInit?.Invoke(z);
		return z;
	}

	public static TControl ContentInit<TControl>(
		this ContentControl ContentControl
		,TControl ControlAsContent
		,Action<TControl>? FnInit = null
	){
		ContentControl.Content = ControlAsContent;
		FnInit?.Invoke(ControlAsContent);
		return ControlAsContent;
	}

	public static TSelf VAlign<TSelf>(
		this TSelf z
		,VerticalAlignment v
	)
		where TSelf:Layoutable
	{
		z.VerticalAlignment = v;
		return z;
	}

	public static TSelf HAlign<TSelf>(
		this TSelf z
		,HorizontalAlignment v
	)
		where TSelf:Layoutable
	{
		z.HorizontalAlignment = v;
		return z;
	}



}

