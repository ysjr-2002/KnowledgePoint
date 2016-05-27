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

namespace KnowledgePoint.ItemsContainer
{
    /// <summary>
    /// Interaction logic for TreeviewItemContainerWindow.xaml
    /// </summary>
    public partial class TreeviewItemContainerWindow : Window
    {
        List<Person> list = null;
        public TreeviewItemContainerWindow()
        {
            InitializeComponent();

            tree.Background = new SolidColorBrush(Color.FromArgb(255, 60, 65, 68));

            list = new List<Person>
            {
                new Person {  ImageUrl="/images/1.png", Name="ysj", Age="30", PlayMode = PlayMode.Single},
                new Person {  ImageUrl="/images/2.png", Name="dgl", Age="35", PlayMode = PlayMode.SingleCycle},
                new Person {  ImageUrl="/images/3.png", Name="ylz", Age="5", PlayMode = PlayMode.List},
            };

            tree.ItemsSource = list;
        }
    }
}
