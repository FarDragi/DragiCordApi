﻿using FarDragi.DiscordCs.Core.Models.Collections;
using FarDragi.DiscordCs.Core.Models.Enumerators.Guild;
using System;

namespace FarDragi.DiscordCs.Core.Models.Base.Guild
{
    public class DiscordGuild
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public ulong OwnerId { get; set; }
        public string Region { get; set; }
        public string Splash { get; set; }
        public string DiscoverySplash { get; set; }
        public bool IsUnavailable { get; set; }
        public DiscordGuildConfig Config { get; set; }
        public DiscordRoleList Roles { get; set; }
        public DiscordEmojiList Emojis { get; set; }
        public DiscordGuildFeatures Features { get; set; }
        public DiscordGuildMfaLevel MfaLevel { get; set; }
        public ulong? ApplicationId { get; set; }
        public ulong? RulesChannelId { get; set; }
        public DateTime JoinedAt { get; set; }
        public bool IsLarge { get; set; }
        public uint MemberCount { get; set; }
        public DiscordVoiceList VoicesStates { get; set; }
        public DiscordMemberList Members { get; set; }
    }
}