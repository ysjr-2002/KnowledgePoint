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
    /// Interaction logic for TextBoxWindow.xaml
    /// </summary>
    public partial class TextBoxWindow : Window
    {
        public TextBoxWindow()
        {
            InitializeComponent();

            if (_cmd == null)
            {
                _cmd = new SimpleCommand((s) =>
                {
                    System.Windows.Forms.MessageBox.Show("ok");
                });
            }
            this.DataContext = this;
        }

        private ICommand _cmd;
        public ICommand OKCommand
        {
            get
            {
                return _cmd;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(dp.DpName);
        }
    }
}
