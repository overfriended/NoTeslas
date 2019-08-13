using Smod2;
using Smod2.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoTeslas
{
    class CommandToggle : ICommandHandler
    {

        public string GetCommandDescription()
        {
            return "Enable/Disable teslas.";
        }

        public string GetUsage()
        {
            return "TOGGLENT";
        }

        public string[] OnCall(ICommandSender sender, string[] args)
        {
            NoTeslas.isDisabled = !NoTeslas.isDisabled;
            return new string[] { "Teslas have been set to " + NoTeslas.isDisabled };
        }
    }
}
