using Smod2.EventHandlers;
using Smod2.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoTeslas
{
    class OnPlayerDamagedHandler : IEventHandlerPlayerHurt
    {
        public void OnPlayerHurt(PlayerHurtEvent ev)
        {
            if (ev.DamageType == Smod2.API.DamageType.TESLA)
            {
                ev.DamageType = Smod2.API.DamageType.NONE;
                ev.Damage = 0;
            }
        }

    }
}
