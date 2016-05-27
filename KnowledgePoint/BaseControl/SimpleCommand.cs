using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KnowledgePoint.BaseControl
{
    public class SimpleCommand : ICommand
    {
        private Action<object> _act;

        public SimpleCommand(Action<object> act)
        {
            this._act = act;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (_act != null)
                _act(parameter);
        }
    }
}
