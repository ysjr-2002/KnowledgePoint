using KnowledgePoint.FindContenChild;
using KnowledgePoint.LINQ;
using KnowledgePoint.ScrollToLastItem;
using KnowledgePoint.SystemHotkey;
using KnowledgePoint.TargetChanged;
using KnowledgePoint.Tasks;
using KnowledgePoint.Thread;
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
            var win = new ListBoxItemWindow();
            Application.Current.MainWindow = win;
            Application.Current.MainWindow.Show();
        }
    }
}
