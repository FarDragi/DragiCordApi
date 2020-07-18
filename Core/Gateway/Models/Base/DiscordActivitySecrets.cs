﻿using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base
{
    internal class DiscordActivitySecrets
    {
        [JsonProperty("join")]
        public string Join { get; set; }

        [JsonProperty("spectate")]
        public string Spectate { get; set; }

        [JsonProperty("match")]
        public string Match { get; set; }
    }
}