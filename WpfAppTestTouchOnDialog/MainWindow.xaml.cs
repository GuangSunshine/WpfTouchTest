using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppTestTouchOnDialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnShowSysMBox_Click(object sender, RoutedEventArgs e)
        {
            var res = System.Windows.MessageBox.Show(this, "System.Windows.MessageBox", "System", MessageBoxButton.OKCancel);
            Console.WriteLine($"MainWindow btnShowSysMBox_Click, return res {res}");

            BtnClicked_UpdateStatus(sender, e);
        }

        private void btnShowCustomDialog_Click(object sender, RoutedEventArgs e)
        {
            simpleCustomWindow cusWin = new simpleCustomWindow();
            cusWin.Owner = this;
            var res = cusWin.ShowDialog();
            Console.WriteLine($"MainWindow btnShowCustomDialog_Click simpleCustomWindow returned {res}");
        }

        private void btnShowSysMBox_TouchEnter(object sender, TouchEventArgs e)
        {
            Console.WriteLine($"MainWindow btnShowSysMBox_TouchEnter");

        }

        private void btnShowSysMBox_TouchDown(object sender, TouchEventArgs e)
        {
            Console.WriteLine($"MainWindow btnShowSysMBox_TouchDown");

        }

        private void btnShowSysMBox_TouchMove(object sender, TouchEventArgs e)
        {
            Console.WriteLine($"MainWindow btnShowSysMBox_TouchMove");

        }

        private void btnShowSysMBox_TouchUp(object sender, TouchEventArgs e)
        {
            Console.WriteLine($"MainWindow btnShowSysMBox_TouchUp");

        }

        private void btnShowSysMBox_TouchLeave(object sender, TouchEventArgs e)
        {
            Console.WriteLine($"MainWindow btnShowSysMBox_TouchLeave");

        }

        private void btnShowSysMBox_PreviewTouchDown(object sender, TouchEventArgs e)
        {
            Console.WriteLine($"MainWindow btnShowSysMBox_PreviewTouchDown");

        }

        private void btnShowSysMBox_PreviewTouchMove(object sender, TouchEventArgs e)
        {
            Console.WriteLine($"MainWindow btnShowSysMBox_PreviewTouchMove");

        }

        private void btnShowSysMBox_PreviewTouchUp(object sender, TouchEventArgs e)
        {
            Console.WriteLine($"MainWindow btnShowSysMBox_PreviewTouchUp");

        }

        private void btnShowSysMBox_GotTouchCapture(object sender, TouchEventArgs e)
        {
            Console.WriteLine($"MainWindow btnShowSysMBox_GotTouchCapture");

        }

        private void btnShowSysMBox_LostTouchCapture(object sender, TouchEventArgs e)
        {
            Console.WriteLine($"MainWindow btnShowSysMBox_LostTouchCapture");

        }

        private void btnShowSysMBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Console.WriteLine($"MainWindow btnShowSysMBox_GotFocus");
        }

        private void btnShowSysMBox_LostFocus(object sender, RoutedEventArgs e)
        {
            Console.WriteLine($"MainWindow btnShowSysMBox_LostFocus");

        }

        private void btnShowSysMBox_GotTouchCapture_1(object sender, TouchEventArgs e)
        {

        }

        private void btnShowSysMBox_LostTouchCapture_1(object sender, TouchEventArgs e)
        {

        }

        private void BtnClicked_UpdateStatus(object sender, RoutedEventArgs e)
        {
            lbStatus.Content = string.Format($"{((Button)sender).Name} clicked. {DateTime.Now:hh:mm:ss.fff}");
        }
    }
}
