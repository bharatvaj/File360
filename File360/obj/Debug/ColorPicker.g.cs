﻿

#pragma checksum "C:\Users\Puli Bharatvaj\Documents\Visual Studio 2013\Projects\Commercial\File360\File360\ColorPicker.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C43B73DB733357F7DA98B3714652EFBE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace File360
{
    partial class ColorPicker : global::Windows.UI.Xaml.Controls.UserControl, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 17 "..\..\ColorPicker.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Unchecked += this.ButtonUncheck;
                 #line default
                 #line hidden
                #line 17 "..\..\ColorPicker.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.ButtonCheck;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 29 "..\..\ColorPicker.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.ColorContainer_SelectionChanged;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


