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

namespace KnowledgePoint.BaseControl
{
    /// <summary>
    /// Interaction logic for PasswordWindow.xaml
    /// </summary>
    public partial class PasswordWindow : Window
    {
        public PasswordWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var val = AttachProperty.GetMyValue(lbl);
            System.Diagnostics.Debug.WriteLine(val);


            var val1 = AttachProperty.GetMyValue(lbl1);
            System.Diagnostics.Debug.WriteLine("no attach value:" + val1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AttachProperty.SetMyValue(lbl, new Random().Next(1, 100));
        }
    }
}
