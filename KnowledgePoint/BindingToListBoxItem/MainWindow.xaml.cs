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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KnowledgePoint
{
    /// <summary>
    ///在ListBoxItem项上绑定ViewModle.Command
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonViewModel view = null;
        public MainWindow()
        {
            InitializeComponent();

            view = new PersonViewModel();
            this.DataContext = view;
        }
    }
}
