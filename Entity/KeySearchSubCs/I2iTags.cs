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
    public class I2iTags
    {

        [JsonProperty("samestyle")]
        public Samestyle Samestyle { get; set; }

        [JsonProperty("similar")]
        public Similar Similar { get; set; }
    }

}
