﻿using FarDragi.DiscordCs.Logging;
using System.Text.Json;

namespace FarDragi.DiscordCs.Rest
{
    public interface IRestContext
    {
        public IRestClient GetClient(string key, string urlFormat, JsonSerializerOptions serializerOptions, ILogger logger);
        public void Init();
        public void Config(IRestConfig config);
    }
}
