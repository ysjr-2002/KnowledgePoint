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

namespace KnowledgePoint.BaseControl
{
    /// <summary>
    /// Interaction logic for DPUserControl.xaml
    /// </summary>
    public partial class DPUserControl : UserControl
    {
        public DPUserControl()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        public string DpName
        {
            get { return (string)GetValue(DpNameProperty); }
            set { SetValue(DpNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DpName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DpNameProperty =
            DependencyProperty.Register("DpName", typeof(string), typeof(DPUserControl));


        public string NormalMame { get; set; }



        public ICommand PDCommand
        {
            get { return (ICommand)GetValue(PDCommandProperty); }
            set { SetValue(PDCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PDCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PDCommandProperty =
            DependencyProperty.Register("PDCommand", typeof(ICommand), typeof(DPUserControl));

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    if (PDCommand != null)
        //    {
        //        PDCommand.Execute("");
        //    }
        //}
    }
}
