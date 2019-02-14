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
    version = "1.0.0",
    SmodMajor = 3,
    SmodMinor = 0,
    SmodRevision = 0
    )]
    public class NoTeslas : Plugin
    {
        public override void OnDisable()
        {
            this.Info(this.Details.name + " now disabled.");
        }

        public override void OnEnable()
        {
            this.Info(this.Details.name + " now enabled.");
        }

        public override void Register()
        {
            this.AddEventHandler(typeof(IEventHandlerPlayerHurt), new OnPlayerDamagedHandler());
        }
    }
}
