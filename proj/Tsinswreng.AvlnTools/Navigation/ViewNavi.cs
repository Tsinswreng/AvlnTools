using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
namespace Tsinswreng.AvlnTools.Navigation;
public  partial class ViewNavi
	//:UserControl
	:IViewNavi
{
	public ViewNavi(){
		Container = new ContentControl();
	}

	public ViewNavi(ContentControl Container){
		this.Container = Container;
	}

	public nil InitCurrent(Control current){
		if(Container != null){
			return NIL;
		}
		Add(current);
		return NIL;
	}

	public void Add(Control ctrl){
		Container.Content = ctrl;//勿用訪問器 會導致循環參照
		Stack.Add(ctrl);
	}


	public ObservableCollection<Control?> Stack{get;set;} = new(){};
	public Control? Peek{
		get{
			return Stack.Last();
		}
		set{
			Stack[Stack.Count-1] = value;
		}
	}

	public ContentControl Container{get;}

	public bool Back(){
		if(Stack.Count <= 1){
			return false;
		}
		//stack.count >= 2
		var last = Stack[Stack.Count-1];
		Stack.RemoveAt(Stack.Count-1);
		var target = Stack[Stack.Count -1];
		if(Container != null){
			Container.Content = target; //target與Current潙同一對象則棧溢出
		}
		return true;

	}

	public void GoTo(Control view){
		Stack.Add(view);
		if(Container != null){//TODO
			Container.Content = view;
		}
		// if(view is I_ViewNavi navigatorView){
		// 	navigatorView.ViewNavigator = this;
		// }
		if(view.DataContext is I_ViewNavi ViewNavi
			&& ViewNavi.ViewNavi == null
		){//TODO
			ViewNavi.ViewNavi = this;
		}
	}
}

class StackView
	:UserControl
{
	public StackView(){
		var view = new Welcome();
		var navigator = new ViewNavi(this);
		navigator.GoTo(view);
	}
}

class Welcome
	:UserControl
	,I_ViewNavi
{
	public IViewNavi? ViewNavi{get;set;}
	public Welcome(){
		var btn = new Button();
		Content = btn;
		btn.Click +=(s,e)=>{
			ViewNavi?.GoTo(
				new Login()
			);
		};
	}
}

class Login
	:UserControl
	,I_ViewNavi
{
	public IViewNavi? ViewNavi{get;set;}
	public Login(){
		var backBtn = new Button();
		Content = backBtn;

		backBtn.Click += (s,e)=>{
			ViewNavi?.Back();
		};
	}
}
