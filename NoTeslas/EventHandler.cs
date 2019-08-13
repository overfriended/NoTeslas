using Smod2;
using Smod2.EventHandlers;
using Smod2.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoTeslas
{
    class EventHandler : IEventHandlerPlayerHurt, IEventHandlerPlayerTriggerTesla
    {
        private readonly NoTeslas plugin;
        private static IConfigFile Config => ConfigManager.Manager.Config;

        public EventHandler(NoTeslas plugin)
        {
            this.plugin = plugin;
        }

        public void OnPlayerHurt(PlayerHurtEvent ev)
        {
            if (ev.DamageType == Smod2.API.DamageType.TESLA)
            {
                ev.Damage = 0;
            }
        }
        public void OnPlayerTriggerTesla(PlayerTriggerTeslaEvent ev)
        {
            ev.Triggerable = NoTeslas.isDisabled;
        }
    }
}
