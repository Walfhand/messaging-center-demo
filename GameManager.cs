﻿using MessaginCenterDemo.Interface;
using System;

namespace MessaginCenterDemo
{
    public class GameManager
    {
        public GameManager(IMessagingCenter messagingCenter)
        {
            messagingCenter.Subscribe<Player>(this, "SANS_ARGS", (sender) =>
            {
                //Je m'abonne à test sender avec un message 'SANS_ARGS'
                Console.WriteLine("Callback sans args");
            });

            //A savoir : tu peux passer ce que tu veux en argument donc tu peux recevoir dans ton callback n'importe quel objet
            messagingCenter.Subscribe<Player, string>(this, "AVEC_ARGS", (sender, args) =>
            {
                //Je m'abonne à test sender avec un message 'AVEC_ARGS'
                Console.WriteLine(args);
            });
        }
    }
}