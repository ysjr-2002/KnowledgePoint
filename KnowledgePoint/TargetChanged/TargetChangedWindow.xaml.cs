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

namespace KnowledgePoint.TargetChanged
{
    /// <summary>
    /// 绑定目标的值发生变化后，通知后台代码
    /// </summary>
    public partial class TargetChangedWindow : Window
    {
        public TargetChangedWindow()
        {
            InitializeComponent();
            Person = new Person();
            this.DataContext = this;
        }

        public Person Person { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dt = (sender as Button).DataContext;
            if (dt is TargetChangedWindow)
            {
                var window = dt as TargetChangedWindow;
                System.Diagnostics.Debug.WriteLine(window.Person.Name);
            }
        }

        private void StackPanel_TargetUpdated(object sender, DataTransferEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("target updated event:" + e.Source.ToString());
        }

        private void StackPanel_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            if (e.OriginalSource is TextBox)
            {
                var txt = (e.OriginalSource as TextBox).Text;
                System.Diagnostics.Debug.WriteLine("source updated event:" + txt);
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("这么麻烦？");
        }
    }
}
