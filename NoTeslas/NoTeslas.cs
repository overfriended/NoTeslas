using Smod2;
using System;
using Smod2.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smod2.EventHandlers;

namespace NoTeslas
{
    [PluginDetails(
    author = "overfriended",
    name = "NoTeslas",
    description = "Negates any damage by teslas.",
    id = "overfriended.noteslas",
    version = "1.1.0s",
    SmodMajor = 3,
    SmodMinor = 0,
    SmodRevision = 0
    )]
    public class NoTeslas : Plugin
    {

        public static NoTeslas Plugin { get; set; }
        private static IConfigFile Config => ConfigManager.Manager.Config;
        public static bool isDisabled = false;

        public override void OnDisable()
        {
            this.Info(this.Details.name + " disabled.");
        }

        public override void OnEnable()
        {
            this.Info(this.Details.name + " enabled.");
        }

        public override void Register()
        {
            this.AddEventHandlers(new EventHandler(this));
            this.AddCommand("togglent", new CommandToggle());
        }
    }
}
