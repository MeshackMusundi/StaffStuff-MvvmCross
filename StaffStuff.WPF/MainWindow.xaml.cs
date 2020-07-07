using System;
using System.Windows;
using System.Windows.Media.Imaging;
using MvvmCross.Platforms.Wpf.Views;

namespace StaffStuff.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MvxWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Icon = BitmapFrame.Create(Application.GetResourceStream(new Uri("icon.png", UriKind.RelativeOrAbsolute)).Stream);
        }
    }
}
