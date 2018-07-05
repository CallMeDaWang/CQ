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
    public class Filter
    {

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("trace")]
        public string Trace { get; set; }

        [JsonProperty("traceData")]
        public TraceData TraceData { get; set; }

        [JsonProperty("isHighlight")]
        public bool IsHighlight { get; set; }

        [JsonProperty("pos")]
        public int Pos { get; set; }

        [JsonProperty("dom_id")]
        public string DomId { get; set; }
    }

}