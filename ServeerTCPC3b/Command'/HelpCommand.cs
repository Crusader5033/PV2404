using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeerTCPC3b.Command_
{
    public class HelpCommand : ICommand
    {
        public string Execute()
        {
            return "help, time";
        }
    }
}
