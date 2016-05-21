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

namespace KnowledgePoint.SystemHotkey
{
    /// <summary>
    /// 全局热键知识点
    /// </summary>
    public partial class HotkeyWindow : Window
    {
        public static readonly DependencyProperty MyKeyProperty =
            DependencyProperty.Register("MyKey", typeof(string), typeof(HotkeyWindow), new PropertyMetadata(""));

        public HotkeyWindow()
        {
            InitializeComponent();

            this.Loaded += HotkeyWindow_Loaded;
            this.Unloaded += HotkeyWindow_Unloaded;
            this.DataContext = this;
        }

        public string MyKey
        {
            get { return (string)GetValue(MyKeyProperty); }
            set { SetValue(MyKeyProperty, value); }
        }

        private void HotkeyWindow_Unloaded(object sender, RoutedEventArgs e)
        {
            key.UnregisterHotKey();
        }

        HotKey key = null;
        private void HotkeyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            key = new HotKey(ModifierKeys.None, System.Windows.Forms.Keys.A, this);
            key.HotKeyPressed += Key_HotKeyPressed;
        }

        private void Key_HotKeyPressed(HotKey obj)
        {
            MyKey = obj.Key.ToString();
        }
    }
}
