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

namespace KnowledgePoint.ScrollToLastItem
{
    /// <summary>
    /// Interaction logic for ListBoxItemWindow.xaml
    /// </summary>
    public partial class ChangeLabelDefaultSelectedColor : Window
    {
        public ChangeLabelDefaultSelectedColor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lb.Items.Add(DateTime.Now.ToString("HH:mm:ss"));
            lb.SelectedIndex = lb.Items.Count - 1;

            var str1 = this.FindResource("str1") as string;
            var str2 = this.FindResource("str2") as string;

            var str3 = "";
            var str4 = "";
            var logcichilds = LogicalTreeHelper.GetChildren(this);
            foreach (var item in logcichilds)
            {
                var t = item;
                if( t is StackPanel)
                {
                    var sp = t as StackPanel;
                    str3 = sp.FindResource("str3") as string;
                    str4 = sp.FindResource("str4") as string;
                }
            }


            var visualchilds = VisualTreeHelper.GetChild(this, 0);
            var childcount = VisualTreeHelper.GetChildrenCount(this);

            System.Diagnostics.Debug.WriteLine(str1);
            System.Diagnostics.Debug.WriteLine(str2);
            System.Diagnostics.Debug.WriteLine(str3);
            System.Diagnostics.Debug.WriteLine(str4);
        }
    }
}
