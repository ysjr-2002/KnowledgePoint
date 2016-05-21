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
    public partial class ListBoxItemWindow : Window
    {
        public ListBoxItemWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lb.Items.Add(DateTime.Now.ToString("HH:mm:ss"));
            lb.SelectedIndex = lb.Items.Count - 1;
        }
    }
}
