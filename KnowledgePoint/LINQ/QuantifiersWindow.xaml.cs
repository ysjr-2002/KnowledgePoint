using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace KnowledgePoint.LINQ
{
    /// <summary>
    /// Interaction logic for QuantifiersWindow.xaml
    /// </summary>
    public partial class QuantifiersWindow : Window
    {
        List<int> numbers = new List<int> { -1, -2, -3, -4, -5, 6 };
        List<string> names = new List<string> { "ysj", "dgl", "ylz" };
        public QuantifiersWindow()
        {
            InitializeComponent();

            this.Loaded += QuantifiersWindow_Loaded;
        }

        void log(object obj)
        {
            System.Diagnostics.Debug.WriteLine(obj.ToString());
        }

        /// <summary>
        /// 只要一个元素满足条件，即为true
        /// </summary>
        private void Any()
        {
            var b = false;

            b = numbers.Any();
            Debug.Assert(b);

            b = numbers.Any(s => s > 0);
            Debug.Assert(b);

            b = numbers.Any(s => s < 0);
            b = numbers.Any(predicateany);
            Debug.Assert(b);

            List<int> temp = new List<int>();
            Debug.Assert(temp.Any() == false);
        }

        private bool predicateany(int i)
        {
            Debug.WriteLine(i);
            if (i < 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 必须全部满足条件才为true，
        /// </summary>
        private void All()
        {
            var b = false;
            b = numbers.All(s =>
            {
                Debug.WriteLine("all " + s);
                if (s > -1)
                    return true;
                else
                    return false;
            });
            log(b);
        }

        private void QuantifiersWindow_Loaded(object sender, RoutedEventArgs e)
        {
            All();
        }
    }
}
