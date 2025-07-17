using System;
using System.Collections.Generic;
using Avalonia.Collections;
using Avalonia.Controls;

namespace Tsinswreng.Avalonia.Dsl;
using Controls = global::Avalonia.Controls.Controls;
public static class AvlnDsl{
	//[Obsolete("類型推斷時優先根據前ʹ參數、則TItem恆潙Control")]
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

}

