﻿using Newtonsoft.Json;
using System.IO;

namespace DiscordAutoEmojiBot
{
    class Config
    {
        public string Token = "";
        public ulong GuildID = 0;
        public ulong ChannelID = 0;
        public string[] Reactions = { ":thumbsup:", ":thumbsdown:", ":interrobang:" };

        public static Config Read(string path)
        {
            if (!File.Exists(path))
            {
                Config cfg = new Config();
                File.WriteAllText(path, JsonConvert.SerializeObject(cfg, Formatting.Indented));
                return cfg;
            }
            return JsonConvert.DeserializeObject<Config>(File.ReadAllText(path));
        }
    }
}
