﻿

#pragma checksum "C:\dev\box-windows-sdk\Box.V2.W8\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D211D549AD250F45BD38C1577991D568"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Box.V2.W8
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 10 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.mainPage_Loaded;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 23 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Refresh_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 17 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Upload_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 19 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Download_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 50 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.FolderView_ItemClick;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 40 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


