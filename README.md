# AvlnTools

Avalonia Tools

This is a collection of tools for Avalonia UI framework. Especially for
Avalonia in pure C# (Without XAML)

-   Fluent API

-   Simplified Compiletime Binding

-   Functional Converter

-   AOT-compatible

-   Controls(or Control Tools):

    -   AutoGrid

    -   Buttons that support Long press and swipe

# What's it like?

``` cs
using Tsinswreng.AvlnTools.Controls;
using Tsinswreng.AvlnTools.Dsl;
using Tsinswreng.AvlnTools.Tools;
using static Tsinswreng.AvlnTools.Dsl.DslFactory;
using Ctx = MyViewModel;

public partial class MyView:UserControl{
    public MyView(){Render();}
    AutoGrid Root = new (IsRow: true);
    protected void Render(){
        // equivalent: this.Content = Root.Grid;
        this.ContentInit(Root.Grid, o=>{
            // initialize the grid in the lambda
            o.RowDefinitions.AddRange([
                //Simplified row or column definition using factory function
                RowDef(1, GUT.Auto),//overlay
                RowDef(1, GUT.Auto),
                RowDef(4, GUT.Star),
                RowDef(1, GUT.Auto),//GridSplitter
                RowDef(5, GUT.Star),
            ]);
        });
        {{
            //Add Children into AutoGrid and initialize them with lambda
            // Border() is also a control factory function, so you don't need to use "new" keyword
            Root.AddInit(Border(), o=>{
                o.Background = new SolidColorBrush(Color.FromArgb((byte)(255 * 0.35), 0, 0, 0));
                o.ZIndex = -1;
            })
            .AddInit(_Menu()) // chaining call
            .AddInit(ScrollViewer(), Scr=>{
                Scr.ContentInit(_ListWordCard(), o=>{
                    o.Bind(
                        ItemsControl.ItemsSourceProperty
                        // Compiletime binding, AOT-compatible
                        ,CBE.Mk<Ctx>(x=>x.WordCards, Mode: BindingMode.TwoWay)
                    );
                });
                Root.AddInit(GridSplitter(), o=>{
                    o.Background = Brushes.Black;
                    o.BorderThickness = new Thickness(1);
                    o.BorderBrush = Brushes.LightGray;
                }).AddInit(_WordInfo(), o=>{
                    o.Bind(Control.DataContextProperty
                        ,CBE.Mk<Ctx>(x=>x.CurWordInfo, Mode: BindingMode.TwoWay)
                    );
                });
            });
        }}
        return;
    }
}
```
