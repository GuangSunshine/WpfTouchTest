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

        private void btnShowSys_Click(object sender, RoutedEventArgs e)
        {
            var res = System.Windows.MessageBox.Show(this, "System.Windows.MessageBox", "System", MessageBoxButton.OKCancel);
            Console.WriteLine($"MainWindow btnShowSys_Click, return res {res}");
        }

        private void btnShowCustomDialog_Click(object sender, RoutedEventArgs e)
        {
            simpleCustomWindow cusWin = new simpleCustomWindow();
            cusWin.Owner = this;
            var res = cusWin.ShowDialog();
            Console.WriteLine($"MainWindow btnShowCustomDialog_Click simpleCustomWindow returned {res}");
        }
    }
}
