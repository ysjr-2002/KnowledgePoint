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

namespace KnowledgePoint.FindContenChild
{
    /// <summary>
    /// Interaction logic for FindUserControlChildWindow.xaml
    /// </summary>
    public partial class FindUserControlChildWindow : Window
    {
        public FindUserControlChildWindow()
        {
            InitializeComponent();
            this.Loaded += FindUserControlChildWindow_Loaded;
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            var p = PointToScreen(Mouse.GetPosition(this));
            lblMousePos.Content = p.ToString();
            //var absoluteScreenPos = PointToScreen(Mouse.GetPosition(new Point(), this));
            base.OnMouseDown(e);
        }

        private void FindUserControlChildWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void UserControlFind_Click(object sender, RoutedEventArgs e)
        {
            var tb1 = this.sp.FindName("tb1") as TextBox;
            var tb2 = this.sp.FindName("tb2") as TextBox;

            tb1.Text = "TextBox1";
            tb2.Text = "TextBox2";

            var par = (tb1.Parent as StackPanel);
            var tb3 = par.Children[5] as TextBox;
            tb3.Text = "TextBox3";

            tb3 = par.FindName("tb3") as TextBox;
            tb3.Text = "Find by name";
        }

        private void FindChildInContenTemplate_Click(object sender, RoutedEventArgs e)
        {
            var tb1 = this.cp.ContentTemplate.FindName("tb1", cp) as TextBox;
            tb1.Text = "TextBox1";
        }

        private void FindChildInTemplate_Click(object sender, RoutedEventArgs e)
        {
            //var tb1 = this.uc.Template.FindName("tb1", uc) as TextBox;
            //tb1.Text = "TextBox1";
        }
    }
}
