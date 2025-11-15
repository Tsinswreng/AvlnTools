using System;
using System.Globalization;
using Avalonia;
using Avalonia.Data.Converters;

namespace Tsinswreng.AvlnTools.Tools;

public  partial class ParamFnConvtr<TIn, TRet>
	:IValueConverter
{
	public Func<TIn, object?, TRet>? FnConv{get;set;}
	public Func<TRet, object?, TIn>? FnBack{get;set;}
		public ParamFnConvtr(Func<TIn, object?, TRet> FnConv){
			this.FnConv = FnConv;
		}

	public ParamFnConvtr(
		Func<TIn, object?, TRet> FnConv
		,Func<TRet, object?, TIn> FnBack
	){
		this.FnConv = FnConv;
		this.FnBack = FnBack;
	}

	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture) {
		if(FnConv == null){
			return AvaloniaProperty.UnsetValue;
		}
		//直強轉 勿用is匹配、緣null is xxx旹恆返false、縱xxx可潙null
		return FnConv.Invoke((TIn)value!, parameter);
	}

	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) {
		if(FnBack == null){
			return AvaloniaProperty.UnsetValue;
		}
		return FnBack.Invoke((TRet)value!, parameter);
	}
}



public partial class SimpleFnConvtr<TIn, TRet>
	:IValueConverter
{
	public Func<TIn, TRet>? FnConv{get;set;}
	public Func<TRet, TIn>? FnBack{get;set;}
		public SimpleFnConvtr(Func<TIn, TRet> FnConv){
			this.FnConv = FnConv;
		}

	public SimpleFnConvtr(
		Func<TIn, TRet> FnConv
		,Func<TRet, TIn> FnBack
	){
		this.FnConv = FnConv;
		this.FnBack = FnBack;
	}

	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture) {
		if(FnConv == null){
			return AvaloniaProperty.UnsetValue;
		}
		//直強轉 勿用is匹配、緣null is xxx旹恆返false、縱xxx可潙null
		return FnConv.Invoke((TIn)value!);
	}

	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) {
		if(FnBack == null){
			return AvaloniaProperty.UnsetValue;
		}
		return FnBack.Invoke((TRet)value!);
	}
}
