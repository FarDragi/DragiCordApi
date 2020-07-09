﻿using System;

namespace FarDragi.DragiCordApi.Core.Gateway.Models.Enumerators
{
    [Flags]
    internal enum DiscordBadges
    {
        None = 0,
        DiscordEmployee = 1,
        DiscordPartner = 2,
        HypeSquadEvents = 4,
        BugHunterLevel1 = 8,
        HouseBravery = 16,
        HouseBrilliance = 32,
        HouseBalance = 64,
        EarlySupporter = 128,
        TeamUser = 256,
        System = 512,
        BugHunterLevel2 = 1024,
        VerifiedBot = 2048,
        VerifiedBotDeveloper = 4096
    }
}
