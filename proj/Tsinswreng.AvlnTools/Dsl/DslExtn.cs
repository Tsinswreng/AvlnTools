using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Markup.Xaml.MarkupExtensions.CompiledBindings;
using Avalonia.Styling;
using Tsinswreng.AvlnTools.Tools;

namespace Tsinswreng.AvlnTools.Dsl;
using Controls = global::Avalonia.Controls.Controls;
using NonGenericList = System.Collections.IList;
public static class DslExtn{

	extension<T>(ref T z)
		where T:struct
	{
		public void Set(T o){
			z = o;
		}
	}
	
	public static BindingExpressionBase CBind<TTar>
	(
		this AvaloniaObject z, AvaloniaProperty AvlnProp
		,Expression<Func<TTar, object?>> TargetPropSlctr
		//do not rename the following param
		//keep them the same as the prop of Binding
		,BindingMode Mode = default
		,IValueConverter? Converter = default
		,object? ConverterParameter = default
		,CompiledBindingPath? Path = default
		,object? Source = default
		,Type? DataType = default
	){
		return z.Bind(AvlnProp, CBE.Mk(
			TargetPropSlctr, Mode, Converter, ConverterParameter, Path, Source, DataType
		));
	}

	//下ʹ方法 須 手動傳兩泛型參數、不便也
	// public static BindingExpressionBase CBind<TCtrl, TTar>
	// (
	// 	this TCtrl z, Func<TCtrl, AvaloniaProperty> AvlnPropScltr
	// 	,Expression<Func<TTar, object?>> TargetPropSlctr
	// 	,BindingMode Mode = default
	// 	,IValueConverter? Converter = default
	// 	,object? ConverterParameter = default
	// 	,CompiledBindingPath? Path = default
	// 	,object? Source = default
	// 	,Type? DataType = default
	// )where TCtrl:Control
	// {
	// 	var AvlnProp = AvlnPropScltr(z);
	// 	return z.Bind(AvlnProp, CBE.Mk(
	// 		TargetPropSlctr, Mode, Converter, ConverterParameter, Path, Source, DataType
	// 	));
	// }


	public static NonGenericList A<TItem>(
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

	public static Style AddTo(
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


	public static ICollection<IStyle> A<TItem>(
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

	public static ICollection<Control> A<TItem>(
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
		Controls.A(z,FnInit);
		return z;
	}

	public static TControl Attach<TControl>(
		this TControl z
		,Panel Panel
		,Action<TControl>? FnInit = null
	)where TControl:Control{
		Panel.A(z,FnInit);
		return z;
	}


	public static Controls A<TChild>(
		this Controls z
		,TChild Child
		,Action<TChild>? FnInit = null
	)where TChild: Control{
		z.Add(Child);
		FnInit?.Invoke(Child);
		return z;
	}

	public static Panel A<TChild>(
		this Panel z
		,TChild Child
		,Action<TChild>? FnInit = null
	)where TChild:Control{
		z.Children.A(Child,FnInit);
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

	[Obsolete("Use InitContent")]
	public static TControl ContentInit<TControl>(
		this ContentControl ContentControl
		,TControl ControlAsContent
		,Action<TControl>? FnInit = null
	){
		ContentControl.Content = ControlAsContent;
		FnInit?.Invoke(ControlAsContent);
		return ControlAsContent;
	}

	public static TControl InitContent<TControl>(
		this ContentControl ContentControl
		,TControl ControlAsContent
		,Action<TControl>? FnInit = null
	){
		ContentControl.Content = ControlAsContent;
		FnInit?.Invoke(ControlAsContent);
		return ControlAsContent;
	}

	public static TControl InitChild<TControl>(
		this Decorator ContentControl
		,TControl ControlAsContent
		,Action<TControl>? FnInit = null
	)where TControl:Control{
		ContentControl.Child = ControlAsContent;
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

	extension<TCtrl>(TCtrl z)
		where TCtrl:Control
	{
		public Action<TCtrl> Init{
			set{value(z);}
		}

		public (AvaloniaProperty property, IBinding binding) Bind{
			set{
				z.Bind(value.property,value.binding);
			}
		}
	}

}

