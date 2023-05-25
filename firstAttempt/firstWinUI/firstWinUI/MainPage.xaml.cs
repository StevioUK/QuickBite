using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace firstWinUI
{
    ///DB PASS: R4Fv5zcHtHxKI5PM

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        void OnClick1(object sender, RoutedEventArgs e)
        {
            btn1.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
            text1.Text = "Click event occurs on Hover.";
            text2.Text = "";
            text3.Text = "";
        }

        void OnClick2(object sender, RoutedEventArgs e)
        {
            btn2.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
            text1.Text = "";
            text2.Text = "Click event occurs on Press.";
            text3.Text = "";
        }

        void OnClick3(object sender, RoutedEventArgs e)
        {
            btn1.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
            btn2.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
            text1.Text = "";
            text2.Text = "";
            text3.Text = "Click event occurs on Release.";
        }
    }
}
