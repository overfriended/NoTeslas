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
        private readonly NoTeslas plugin;

        public CommandToggle(NoTeslas plugin)
        {
            this.plugin = plugin;
        }

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
            plugin.pluginManager.DisablePlugin(plugin);
            return new string[] { "Teslas have been enabled. You will be required to restart the server to fix this." };
        }
    }
}
