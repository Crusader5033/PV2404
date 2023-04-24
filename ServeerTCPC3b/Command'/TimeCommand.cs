using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeerTCPC3b.Command_
{
    public class TimeCommand : ICommand
    {
        public string Execute()
        {
            return DateTime.Now.ToString();
        }
    }
}
