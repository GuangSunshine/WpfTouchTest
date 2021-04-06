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
using System.Windows.Shapes;

namespace WpfAppTestTouchOnDialog
{
    /// <summary>
    /// Interaction logic for simpleCustomWindow.xaml
    /// </summary>
    public partial class simpleCustomWindow : Window
    {
        public simpleCustomWindow()
        {
            InitializeComponent();
        }

        private void btnSimpleWindowOK_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine($"simpleCustomWindow btnSimpleWindowOK_Click, close");
            Close();
        }

        private void btnSimpleWindowCancel_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine($"simpleCustomWindow btnSimpleWindowCancel_Click, close");
            Close();
        }
    }
}
