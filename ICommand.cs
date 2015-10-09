using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Kevoree.Core.Api.Command
{
    public interface ICommand
    {
        bool Execute();
        void Undo();
        string Name();
    }
}
