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

namespace KnowledgePoint.RoutedEvent
{
    /// <summary>
    /// Interaction logic for BubbleRoutedEventWindow.xaml
    /// </summary>
    public partial class BubbleRoutedEventWindow : Window
    {
        public BubbleRoutedEventWindow()
        {
            InitializeComponent();
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {

            var cursor = this.Cursor;
            System.Diagnostics.Debug.WriteLine((sender as FrameworkElement).ToString());
            System.Diagnostics.Debug.WriteLine((e.Source as FrameworkElement).ToString());
            System.Diagnostics.Debug.WriteLine((e.OriginalSource as FrameworkElement).ToString());
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent.ToString());
            System.Diagnostics.Debug.WriteLine(e.Handled.ToString());
        }
    }
}
