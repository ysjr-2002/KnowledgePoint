using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KnowledgePoint.Thread
{
    /// <summary>
    /// EventWaitHandle知识点学习
    /// </summary>
    public partial class EventWaitHandlerWindow : Window
    {
        public EventWaitHandlerWindow()
        {
            InitializeComponent();

            this.Loaded += EventHandlerWindow_Loaded;
        }

        //true:终止状态(终止状态下WaitOne失效)  false:非终止状态
        //Set  : true   调用一次Set则失效
        //Reset: false
        ManualResetEvent manual = new ManualResetEvent(false);

        private void EventHandlerWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //Task.Run(new Action(Manual));
            Task.Run(new Action(Auto));
        }

        void Manual()
        {
            var i = 1;
            while (i < 10)
            {
                Debug.WriteLine(i);
                i++;
                manual.WaitOne();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            manual.Set();
        }

        //true: 第一次WaitOne失效
        //false:WaitOne立即起效

        //每一次Waitone后，相当于执行一次ManualResetEvent.Reset()
        AutoResetEvent auto = new AutoResetEvent(false);
        void Auto()
        {
            var i = 1;
            while (i < 10)
            {
                Debug.WriteLine(i);
                i++;
                auto.WaitOne();
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            auto.Set();
        }
    }
}
