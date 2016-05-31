using KnowledgePoint.BaseControl;
using KnowledgePoint.FindContenChild;
using KnowledgePoint.ItemsContainer;
using KnowledgePoint.LINQ;
using KnowledgePoint.RebootMachine;
using KnowledgePoint.RoutedEvent;
using KnowledgePoint.ScrollToLastItem;
using KnowledgePoint.SystemHotkey;
using KnowledgePoint.TargetChanged;
using KnowledgePoint.Tasks;
using KnowledgePoint.TextBlockEx;
using KnowledgePoint.Thread;
using KnowledgePoint.TreeViewItem;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KnowledgePoint
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var win = new TaskWindow();
            Application.Current.MainWindow = win;
            Application.Current.MainWindow.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Unhandled Exception:" + e.Exception);
            e.Handled = true;
        }
    }
}
