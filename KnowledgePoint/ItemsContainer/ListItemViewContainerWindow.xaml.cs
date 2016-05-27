using KnowledgePoint.BaseControl;
using KnowledgePoint.WPFTools;
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
using System.Globalization;
using Common.NotifyBase;

namespace KnowledgePoint.ItemsContainer
{
    /// <summary>
    /// Interaction logic for ListItemViewContainerWindow.xaml
    /// </summary>
    public partial class ListItemViewContainerWindow : Window
    {
        List<Person> list = null;
        public ListItemViewContainerWindow()
        {
            InitializeComponent();

            list = new List<Person>
            {
                new Person {  ImageUrl="/images/1.png", Name="ysj", Age="30", PlayMode = PlayMode.Single},
                new Person {  ImageUrl="/images/2.png", Name="dgl", Age="35", PlayMode = PlayMode.SingleCycle},
                new Person {  ImageUrl="/images/3.png", Name="ylz", Age="5", PlayMode = PlayMode.List},
            };

            lbPerson.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var p1 = VisualTreeHelper.GetParent(btn);
            System.Diagnostics.Debug.WriteLine(p1.ToString());
            var p2 = VisualTreeHelper.GetParent(p1);
            System.Diagnostics.Debug.WriteLine(p2.ToString());
            var p3 = VisualTreeHelper.GetParent(p2);
            System.Diagnostics.Debug.WriteLine(p3.ToString());

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var p1 = VisualTreeHelper.GetParent(btn);
            System.Diagnostics.Debug.WriteLine(p1.ToString());
            var p2 = VisualTreeHelper.GetParent(p1);
            System.Diagnostics.Debug.WriteLine(p2.ToString());
            var p3 = VisualTreeHelper.GetParent(p2);
            System.Diagnostics.Debug.WriteLine(p3.ToString());
            var p4 = VisualTreeHelper.GetParent(p3);
            System.Diagnostics.Debug.WriteLine(p4.ToString());
        }

        int index = 0;
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var person = list.ElementAt(0);
            if (index == 0)
                person.PlayMode = PlayMode.Single;
            else if (index == 1)
                person.PlayMode = PlayMode.SingleCycle;
            else
                person.PlayMode = PlayMode.List;

            index++;
            //CheckBoxItem(person);
        }

        private void CheckBoxItem(Person person)
        {
            //var count = lbPerson.Items.Count;
            //count = lbPerson.ItemContainerGenerator.Items.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    var item = lbPerson.Items[i];
            //    System.Diagnostics.Debug.WriteLine(item.ToString());
            var boxItem = lbPerson.ItemContainerGenerator.ContainerFromItem(person);
            System.Diagnostics.Debug.WriteLine(boxItem.ToString());
            var textblock = VisualTreeHelperExtensions.FindChild<TextBlock>(boxItem);
            if (textblock != null)
            {
                var context = textblock.ContextMenu;
                System.Diagnostics.Debug.WriteLine(context.Items.Count);
                var m2 = context.Items[1] as MenuItem;
                m2.IsCheckable = true;
                m2.IsChecked = true;
            }
            //}
        }

        private void ContextMenu_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("opening");
        }

        private void ContextMenu_ContextMenuOpening_1(object sender, ContextMenuEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("cao");
        }
    }

    class Person : PropertyNotifyObject
    {
        public Person()
        {

        }

        public string ImageUrl { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public override string ToString()
        {
            return this.Name;
        }


        private ICommand _add = null;
        public ICommand AddCommand
        {
            get
            {
                if (_add == null)
                {
                    _add = new SimpleCommand((p) =>
                    {
                        var a = p as Person;
                        MessageBox.Show("add " + a.Name);
                    });
                }
                return _add;
            }
        }

        public PlayMode PlayMode
        {
            get { return this.GetValue(s => s.PlayMode); }
            set { this.SetValue(s => s.PlayMode, value); }
        }

    }

    enum PlayMode
    {
        Single,
        SingleCycle,
        List
    }

    class PlayModeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString() == parameter.ToString())
            {
                return true;
            }
            else
                return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
