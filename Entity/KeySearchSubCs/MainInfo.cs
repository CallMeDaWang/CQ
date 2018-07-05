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
    public class MainInfo
    {

        [JsonProperty("currentUrl")]
        public string CurrentUrl { get; set; }

        [JsonProperty("modLinks")]
        public ModLinks ModLinks { get; set; }

        [JsonProperty("srpGlobal")]
        public SrpGlobal SrpGlobal { get; set; }

        [JsonProperty("traceInfo")]
        public TraceInfo TraceInfo { get; set; }

        [JsonProperty("remainMods")]
        public IList<object> RemainMods { get; set; }
    }

}