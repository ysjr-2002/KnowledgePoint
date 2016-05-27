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
    /// Interaction logic for SpinEditorWindow.xaml
    /// </summary>
    public partial class SpinEditorWindow : Window
    {
        public SpinEditorWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            editor.Value++;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            editor.Value--;
            if (editor.Value <= 0)
                throw new ArgumentException("arg error");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            editor.EditValue = new Random().Next(1, 100);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window win = new Window();
            win.Title = "这是一个顶级窗口";
            win.Topmost = true;
            win.ResizeMode = ResizeMode.NoResize;
            win.ShowDialog();
        }
    }
}
