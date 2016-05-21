using Common.NotifyBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgePoint.TargetChanged
{
    public class Person : PropertyNotifyObject
    {
        public string Name
        {
            get { return this.GetValue(s => s.Name); }
            set
            {
                this.SetValue(s => s.Name, value);
                System.Diagnostics.Debug.WriteLine("name changed:" + value);
            }
        }


        public int Age
        {
            get { return this.GetValue(s => s.Age); }
            set { this.SetValue(s => s.Age, value); }
        }
    }
}
