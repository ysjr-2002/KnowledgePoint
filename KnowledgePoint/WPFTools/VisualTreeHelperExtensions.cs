using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
    }
}
