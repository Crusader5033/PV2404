using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeerTCPC3b.Command_
{
    internal class ExitCommand : ICommand
    {
        public string Execute()
        {
            return "Odpojen";
        }
    }
}
