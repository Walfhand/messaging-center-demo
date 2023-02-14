﻿using messaging_center.Interfaces;

namespace messaging_center
{
    internal class Sender
    {
        public Sender(IMessagingCenter messagingCenter)
        {
            messagingCenter.Send(this, "SANS_ARGS");
            messagingCenter.Send(this, "AVEC_ARGS", "Un message de la part d'un sender");
        }
    }
}