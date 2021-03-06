﻿using System;
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
                }
                else
                {
                }
            }));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task task = Task.Run(() =>
            {
                throw new ArgumentException("cx");
            });

            task.ContinueWith((t) =>
            {
                System.Diagnostics.Debug.WriteLine("hz:" + t.Exception);
            }, TaskContinuationOptions.OnlyOnFaulted);

            try
            {
                task.Wait();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("hz: error");
            }
        }


        private Task<bool> StartTask()
        {
            return Task<bool>.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(5000);
                System.Diagnostics.Debug.WriteLine("ok");
                return true;
            });
        }
    }
}
