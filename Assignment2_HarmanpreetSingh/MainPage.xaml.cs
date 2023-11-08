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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Assignment2_HarmanpreetSingh
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string search = txtString.Text;

            if (String.IsNullOrEmpty(search))
            {
                txtReverse.Text = "Please enter String to reverse!";
            }
            else
            {
                string reversedString = ReversedString(search);
                txtReverse.Text = reversedString;
            }
        }

        public string ReversedString(string text)
        {
            char[] reverseArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = reverseArray.Length - 1; i > -1; i--)
            {
                reverse += reverseArray[i];
            }
            return reverse;
        }
    }
}
