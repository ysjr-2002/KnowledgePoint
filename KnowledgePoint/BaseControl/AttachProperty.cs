using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KnowledgePoint.BaseControl
{
    public class AttachProperty : DependencyObject
    {
        public static int GetMyValue(DependencyObject obj)
        {
            return (int)obj.GetValue(MyValueProperty);
        }

        public static void SetMyValue(DependencyObject obj, int value)
        {
            obj.SetValue(MyValueProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyValueProperty =
            DependencyProperty.RegisterAttached("MyValue", typeof(int), typeof(AttachProperty), new PropertyMetadata(0, new PropertyChangedCallback(OnPropertyValueChanged)), new ValidateValueCallback(IsValid));


        public static bool IsValid(object obj)
        {
            if (obj != null)
            {
                System.Diagnostics.Debug.WriteLine("value change:" + obj);
                return true;
            }
            else
                return false;
        }

        public static void OnPropertyValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("label name:" + d.ToString());
            System.Diagnostics.Debug.WriteLine("old value:"+e.OldValue + "   new value:"+ e.NewValue);
        }
    }
}
