﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace mN.NekoAPI.Entities
{
    public class NekoAPIImage
    {
        [JsonProperty("success")]
        public bool Success { get; internal set; }
        [JsonProperty("message")]
        public string Message { get; internal set; }
        [JsonProperty("color")]
        public int Color { get; internal set; }
        [JsonProperty("version")]
        public string Version { get; internal set; }

        [JsonConstructor]
        internal NekoAPIImage()
        {

        }

    }
}
