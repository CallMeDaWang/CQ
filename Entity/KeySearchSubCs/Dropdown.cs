﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CQ.Entity;

namespace CQ.Entity
{

    [Obfuscation(Feature = "trigger", Exclude = false)]
    public class Dropdown
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
    }

}
