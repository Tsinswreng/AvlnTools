
namespace Tsinswreng.AvlnTools.Example;
using System.Collections.ObjectModel;


using Ctx = VmExample;
public partial class VmExample: ViewModelBase{
	//蔿從構造函數依賴注入、故以靜態工廠代無參構造器
	protected VmExample(){}
	public static Ctx Mk(){
		return new Ctx();
	}

	public static ObservableCollection<Ctx> Samples = [];
	static VmExample(){
		#if DEBUG
		{
			var o = new Ctx();
			Samples.Add(o);
		}
		#endif
	}

	public CancellationTokenSource Cts = new();

/*
	public str YYY{
		get{return field;}
		set{SetProperty(ref field, value);}
	}="";
 */

}
