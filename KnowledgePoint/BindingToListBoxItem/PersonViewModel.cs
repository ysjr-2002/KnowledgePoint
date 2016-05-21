using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KnowledgePoint
{
    public class PersonViewModel
    {
        public List<Person> Persons { get; set; }

        public PersonViewModel()
        {
            Persons = new List<Person>();
            Persons.Add(new Person { Age = 1, Name = "ysj" });
            Persons.Add(new Person { Age = 2, Name = "xdp" });
        }

        private DelegateCommand<Person> _open;

        public DelegateCommand<Person> OpenCommand
        {
            get
            {
                if (_open == null)
                {
                    _open = new DelegateCommand<Person>((p) =>
                    {
                        MessageBox.Show(p.Name);
                    });
                }
                return _open;
            }
        }
    }
}
