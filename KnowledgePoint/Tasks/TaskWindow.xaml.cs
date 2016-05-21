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

namespace KnowledgePoint.Tasks
{
    /// <summary>
    /// Interaction logic for TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : Window
    {
        public TaskWindow()
        {
            InitializeComponent();

            this.Loaded += TaskWindow_Loaded;
        }

        private void TaskWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Task.Run<int>(() =>
            {
                return 99;
            }
            ).
            ContinueWith(s => Task.Run(() => 
            {
                if (s.Result == 100)
                {
                    System.Diagnostics.Debug.WriteLine("ok");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("error");
                }
            }));
        }
    }
}
