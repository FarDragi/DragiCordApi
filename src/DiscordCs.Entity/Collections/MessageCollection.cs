﻿using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.MessageModels;
using FarDragi.DiscordCs.Rest;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class MessageCollection : ICacheable<ulong, Message>
    {
        private readonly ICache<ulong, Message> _cache;
        private readonly IRestClient _createMessage;

        public MessageCollection(ICache<ulong, Message> cache, IRestContext rest, JsonSerializerOptions serializerOptions)
        {
            _cache = cache;
            _createMessage = rest.GetClient("/channels/{0}/messages", serializerOptions);
        }

        public Message Caching(ref Message entity)
        {
            _cache.Add(entity.Id, ref entity);
            return entity;
        }

        public Message Find(ulong key)
        {
            return _cache.Get(key);
        }

        public IEnumerator<Message> GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        public async Task<Message> Add(Message message)
        {
            message = await _createMessage.Send<Message, Message>(HttpMethod.Post, message, "814019791958441994");
            return message;
        }
    }
}
