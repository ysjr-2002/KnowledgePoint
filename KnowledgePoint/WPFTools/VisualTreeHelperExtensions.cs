using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace KnowledgePoint.WPFTools
{
    public static class VisualTreeHelperExtensions
    {
        /// <summary>
        /// 查找父对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="current"></param>
        /// <returns></returns>
        public static T FindAncestor<T>(DependencyObject current) where T : DependencyObject
        {
            do
            {
                if (current is T)
                    return (T)current;

                current = FindAncestor<T>(current);

            } while (current != null);

            return null;
        }

        public static T FindChild<T>(DependencyObject root) where T : DependencyObject
        {
            if (root == null)
                return null;

            T founded = null;

            for (int j = 0; j < VisualTreeHelper.GetChildrenCount(root); j++)
            {
                DependencyObject d = VisualTreeHelper.GetChild(root, j);
                T childType = d as T;
                if (childType == null)
                {
                    founded = FindChild<T>(d);
                    if (founded != null)
                        break;
                }
                else
                {
                    founded = childType;
                    break;
                }
            }
            return founded;
        }
    }
}
