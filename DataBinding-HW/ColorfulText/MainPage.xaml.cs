using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ColorfulText.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ColorfulText
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        private void OnRadioCheck(object sender, RoutedEventArgs e)
        {
            var radio = (RadioButton) sender;
            var dataContext = ((RadioButton)sender).DataContext as ColorViewModel;
            if (dataContext !=null)
            {
                dataContext.ForegroundColor = (string) radio.Content;
            }
        }

        private void OnBackRadioCheck(object sender, RoutedEventArgs e)
        {
            var radio = (RadioButton)sender;
            var dataContext = ((RadioButton)sender).DataContext as ColorViewModel;
            if (dataContext != null)
            {
                dataContext.BackgroundColor = (string)radio.Content;
            }
        }
    }
}
